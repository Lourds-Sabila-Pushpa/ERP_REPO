using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ERP.Data;
using ERP.Models.MASTER;

namespace ERP.Controllers.MASTER
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VendorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Vendor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendor>>> GetVendor()
        {
            return await _context.Vendor.ToListAsync();
        }

        // GET: api/Vendor/1
        [HttpGet("{vendorCode}")]
        public async Task<ActionResult<Vendor>> GetVendor(string vendorCode)
        {
            var vendorID = await _context.Vendor.FindAsync(vendorCode);

            if (vendorID == null)
            {
                return NotFound();
            }

            return vendorID;
        }

        // PUT: api/Vendor/V1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{vendorCode}")]
        public async Task<IActionResult> PutVendor(string vendorCode, Vendor vendordet)
        {
            if (vendorCode != vendordet.VENDOR)
            {
                return BadRequest();
            }

            var existingVendor = await _context.Vendor.FindAsync(vendorCode);

            if (existingVendor == null)
            {
                return NotFound($"Vendor {vendorCode} not found.");
            }

            existingVendor.NAME = vendordet.NAME;
            existingVendor.NAMEAR = vendordet.NAMEAR;
            existingVendor.PHONE = vendordet.PHONE;
            existingVendor.EMAIL = vendordet.EMAIL;
            existingVendor.ADDRESS = vendordet.ADDRESS;
            existingVendor.VATNO = vendordet.VATNO;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorExists(vendorCode))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vendor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vendor>> PostVendor(Vendor vendor)
        {
            _context.Vendor.Add(vendor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendor", new { vendor = vendor.VENDOR }, vendor);
        }

        // DELETE: api/Vendor/V1
        [HttpDelete("{vendorCode}")]
        public async Task<IActionResult> DeleteVendor(string vendorCode)
        {
            //var vendorID = await _context.Vendor.FindAsync(id);
            //if (vendorID == null)
            //{
            //    return NotFound();
            //}

            //_context.Vendor.Remove(vendorID);
            //await _context.SaveChangesAsync();

            //return NoContent();

            Console.WriteLine($"Delete request received for ID: {vendorCode}");
            try
            {
                var vendor = await _context.Vendor.FindAsync(vendorCode);
                if (vendor == null)
                {
                    return NotFound();
                }

                _context.Vendor.Remove(vendor);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                // This helps us see what went wrong
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //this is url oqytt
        private bool VendorExists(string vendor)
        {
            return _context.Vendor.Any(e => e.VENDOR == vendor);
        }
    }
}
