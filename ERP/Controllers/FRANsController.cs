using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ERP.Models.MASTER;
using ERP.Data;

namespace ERP.Controllers // ✅ Keep consistent with your project structure
{
    [Route("api/[controller]")]
    [ApiController]
    public class FRANsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FRANsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/FRANs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FRAN>>> GetFRANs()
        {
            return await _context.FRAN.ToListAsync();
        }

        // ✅ GET: api/FRANs/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<FRAN>> GetFRAN(string id)
        {
            var fran = await _context.FRAN.FindAsync(id);
            if (fran == null)
            {
                return NotFound();
            }
            return fran;
        }

        // ✅ PUT: api/FRANs/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFRAN(string id, FRAN fran)
        {
            if (id != fran.FranCode)
            {
                return BadRequest("FranCode mismatch.");
            }

            _context.Entry(fran).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FRANExists(id))
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

        // ✅ POST: api/FRANs
        [HttpPost]
        public async Task<ActionResult<FRAN>> PostFRAN(FRAN fran)
        {
            _context.FRAN.Add(fran);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FRANExists(fran.FranCode))
                {
                    return Conflict("FRAN already exists.");
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetFRAN), new { id = fran.FranCode }, fran);
        }

        // ✅ DELETE: api/FRANs/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFRAN(string id)
        {
            var fran = await _context.FRAN.FindAsync(id);
            if (fran == null)
            {
                return NotFound();
            }

            _context.FRAN.Remove(fran);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // ✅ Helper method
        private bool FRANExists(string id)
        {
            return _context.FRAN.Any(e => e.FranCode == id);
        }
    }
}
