using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FodApi.Data;
using FodApi.Model;

namespace FodApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencesController : ControllerBase
    {
        private readonly FodContext _context;

        public CompetencesController(FodContext context)
        {
            _context = context;
        }

        // GET: api/Competences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competence>>> GetCompetences()
        {
            return await _context.Competences.ToListAsync();
        }

        // GET: api/Competences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Competence>> GetCompetence(int id)
        {
            var competence = await _context.Competences.FindAsync(id);

            if (competence == null)
            {
                return NotFound();
            }

            return competence;
        }

        // PUT: api/Competences/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompetence(int id, Competence competence)
        {
            if (id != competence.id)
            {
                return BadRequest();
            }

            _context.Entry(competence).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetenceExists(id))
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

        // POST: api/Competences
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Competence>> PostCompetence(Competence competence)
        {
            _context.Competences.Add(competence);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompetence", new { id = competence.id }, competence);
        }

        // DELETE: api/Competences/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Competence>> DeleteCompetence(int id)
        {
            var competence = await _context.Competences.FindAsync(id);
            if (competence == null)
            {
                return NotFound();
            }

            _context.Competences.Remove(competence);
            await _context.SaveChangesAsync();

            return competence;
        }

        private bool CompetenceExists(int id)
        {
            return _context.Competences.Any(e => e.id == id);
        }
    }
}
