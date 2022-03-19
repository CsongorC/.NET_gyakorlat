#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_example.Data;
using API_example.Data.Models;

namespace API_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlgorithmsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Algorithms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Algorithms>>> GetAlgorithms()
        {
            return await _context.Algorithms.ToListAsync();
        }

        // GET: api/Algorithms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Algorithms>> GetAlgorithms(int id)
        {
            var algorithms = await _context.Algorithms.FindAsync(id);

            if (algorithms == null)
            {
                return NotFound();
            }

            return algorithms;
        }

        // PUT: api/Algorithms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlgorithms(int id, Algorithms algorithms)
        {
            if (id != algorithms.id)
            {
                return BadRequest();
            }

            _context.Entry(algorithms).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlgorithmsExists(id))
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

        // POST: api/Algorithms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Algorithms>> PostAlgorithms(Algorithms algorithms)
        {
            _context.Algorithms.Add(algorithms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlgorithms", new { id = algorithms.id }, algorithms);
        }

        // DELETE: api/Algorithms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlgorithms(int id)
        {
            var algorithms = await _context.Algorithms.FindAsync(id);
            if (algorithms == null)
            {
                return NotFound();
            }

            _context.Algorithms.Remove(algorithms);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlgorithmsExists(int id)
        {
            return _context.Algorithms.Any(e => e.id == id);
        }
    }
}
