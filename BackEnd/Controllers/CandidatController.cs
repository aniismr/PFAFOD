
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
    public class CandidatController : ControllerBase
    {
        private readonly dbContext _context;
            public CandidatController(dbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidat>>> GetCandidats()
        {   
            
            return await _context.Candidat.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Candidat>> PostCandidat(Candidat candidat)
        {
            _context.Candidat.Add(candidat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCandidat", new { id = candidat.CandidatId }, candidat);
        }

    }
}
