
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using BackEnd.Data;
using System.Text.Json;
namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidatureController : ControllerBase
    {
        private readonly dbContext _context;
            public CandidatureController(dbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidature>>> GetCandidatures()
        {
 
            return await _context.Candidature.Include(can=>can.Candidat)
            .Include(comp=>comp.CompetenceCandidature).ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidature>> GetCandidature(int id)
        {
            var candidature = await _context.Candidature
            .Include(can=>can.Candidat)
            .Include(comp=>comp.CompetenceCandidature)
            .FirstOrDefaultAsync(i=>i.CandidatureID == id);

            if (candidature == null)
            {
                return NotFound();
            }

            return candidature;
        }
        [HttpPost]
        public async Task<ActionResult<Candidature>> PostCandidature(Candidature candidature)
        {
            _context.Candidature.Add(candidature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCandidature", new { id = candidature.CandidatureID }, candidature);
        }
        
    }
}
