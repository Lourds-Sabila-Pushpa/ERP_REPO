using ERP.Data;
using ERP.Models;
using ERP.Models.DTOs;
using ERP.Models.MASTER;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PurchaseOrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/PurchaseOrder
        [HttpPost]
        public async Task<IActionResult> CreatePurchaseOrder([FromBody] PurchaseOrderDTO po)
        {
            if (po == null || po.Header == null || po.Details == null || !po.Details.Any())
                return BadRequest("Invalid Purchase Order data.");

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                // 🔹 Constants for now
                string fran = "A1";
                string brch = "BR1";
                string whse = "WH1";
                string vendor = "V1";
                string doctype = po.Header.Doctype ?? "PO";

                // 🔹 Generate next SEQNO and DOCNO (based on FranCode)
                var (nextSeqNo, nextDocNo) = await GenerateNextSeqAndDocNoAsync(fran);

                // 🔹 Create header
                var header = new POHDR
                {
                    FranCode = fran,
                    BranchCode = brch,
                    WhCode = whse,
                    VENDOR = vendor,
                    DOCTYPE = doctype,
                    DOCNO = nextDocNo,
                    SEQNO = nextSeqNo.ToString(),
                    SEQNOPREFIX = "P", // fixed prefix
                    VENDORREFTYPE = "PO",
                    VENDORREFNO = nextDocNo,
                    CURRENCY = "INR",
                    NOOFITEMS = po.Details.Count,
                    DISCOUNT = 0,
                    TOTALVALUE = po.Details.Sum(d => d.Value),
                    CreateDate = DateTime.Now.Date,
                    CreateTime = DateTime.Now,
                    CreateBy = "system"
                };

                _context.POHDR.Add(header);
                await _context.SaveChangesAsync();

                // 🔹 Create details with same DOCNO
                int serial = 1;
                var details = po.Details.Select(d => new PODET
                {
                    FranCode = fran,
                    BranchCode = brch,
                    WhCode = whse,
                    VENDOR = vendor,
                    DOCTYPE = doctype,
                    DOCNO = nextDocNo,
                    DOCSRL = serial++.ToString("0000"),
                    MAKE = d.Make,
                    PART = d.Part,
                    QTY = d.Qty,
                    PRICE = d.Price,
                    TOTALVALUE = d.Value,
                    DISCOUNT = d.Discount,
                    VATPERCENTAGE = 0,
                    VATVALUE = d.Vat,
                    DISCOUNTVALUE = 0
                }).ToList();

                _context.PODET.AddRange(details);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();

                return Ok(new
                {
                    message = "Purchase Order saved successfully",
                    docNo = nextDocNo
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, $"Error saving Purchase Order: {ex.InnerException?.Message ?? ex.Message}");
            }
        }


        //private async Task<string> GenerateNextDocNoAsync()
        //{
        //    // Fetch the highest DOCNO from POHDR table
        //    var lastPo = await _context.POHDR
        //        .OrderByDescending(p => p.DOCNO)
        //        .FirstOrDefaultAsync();

        //    string nextDocNo;

        //    if (lastPo == null || string.IsNullOrEmpty(lastPo.DOCNO))
        //    {
        //        // No records yet → start from 000001
        //        nextDocNo = "000001";
        //    }
        //    else
        //    {
        //        string docno = lastPo.DOCNO;
        //        // Extract trailing numeric part
        //        string numberPart = new string(docno.Reverse().TakeWhile(char.IsDigit).Reverse().ToArray());

        //        if (int.TryParse(numberPart, out int lastNumber))
        //        {
        //            // Increment and keep same padding
        //            string newNumberPart = (lastNumber + 1).ToString(new string('0', numberPart.Length));
        //            nextDocNo = docno.Substring(0, docno.Length - numberPart.Length) + newNumberPart;
        //        }
        //        else
        //        {
        //            // If DOCNO doesn't end with digits, append "-001"
        //            nextDocNo = $"{docno}-001";
        //        }
        //    }

        //    return nextDocNo;
        //}

        private async Task<(int nextSeqNo, string nextDocNo)> GenerateNextSeqAndDocNoAsync(string fran)
        {
            // Fetch last entry for given FranCode
            var lastHdr = await _context.POHDR
                .Where(p => p.FranCode == fran)
                .OrderByDescending(p => p.SEQNO)
                .FirstOrDefaultAsync();

            int nextSeqNo = 1;
            if (lastHdr != null && int.TryParse(lastHdr.SEQNO, out int lastSeq))
                nextSeqNo = lastSeq + 1;

            // DOCNO format: "E" + 8-digit padded sequence
            string nextDocNo = $"P{nextSeqNo.ToString().PadLeft(8, '0')}";

            return (nextSeqNo, nextDocNo);
        }


    }
}
