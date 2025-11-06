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
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetVendor(int id)
        {
            var vendorID = await _context.Vendor.FindAsync(id);

            if (vendorID == null)
            {
                return NotFound();
            }

            return vendorID;
        }

        // PUT: api/Vendor/V1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendor(int id, Vendor vendordet)
        {
            if (id != vendordet.ID)
            {
                return BadRequest();
            }

            _context.Entry(vendordet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorExists(id))
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

            return CreatedAtAction("GetVendor", new { id = vendor.ID }, vendor);
        }

        // DELETE: api/Vendor/V1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendor(int id)
        {
            //var vendorID = await _context.Vendor.FindAsync(id);
            //if (vendorID == null)
            //{
            //    return NotFound();
            //}

            //_context.Vendor.Remove(vendorID);
            //await _context.SaveChangesAsync();

            //return NoContent();

            Console.WriteLine($"Delete request received for ID: {id}");
            try
            {
                var vendor = await _context.Vendor.FindAsync(id);
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

        //this is
        private bool VendorExists(int id)
        {
            return _context.Vendor.Any(e => e.ID == id);
        }
    }
}
