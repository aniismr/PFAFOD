
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
    public class TestController : ControllerBase
    {
        private readonly dbContext _context;
            public TestController(dbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Test>>> GetTests()
        {   
            
            return await _context.Test.ToListAsync();
        }
        [HttpPost]
                public async Task<ActionResult<Test>> PostTest(Test test)
        {
            foreach(TestCandidature t in test.TestCandidature){
                _context.Candidature.First(a => a.CandidatureID==t.CandidatureID).Reponse="A Tester";
                await _context.SaveChangesAsync();
            }
            _context.Test.Add(test);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTests", new { id = test.TestId }, test);
        }
    }
}