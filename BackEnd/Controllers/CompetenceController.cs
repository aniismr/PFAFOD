
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
    public class CompetenceController : ControllerBase
    {
        private readonly dbContext _context;
            public CompetenceController(dbContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidat>> GetCandidat(int id)
        {
            var candidat= await _context.Candidat
 
            .FirstOrDefaultAsync(i=>i.CandidatId == id);

            if (candidat == null)
            {
                return NotFound();
            }

            return candidat;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competence>>> GetCompetences()
        {   
            
            return await _context.Competence.ToListAsync();
        }


    }
}
