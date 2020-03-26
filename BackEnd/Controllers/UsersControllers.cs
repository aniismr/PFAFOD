using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using BackEnd.Models;
using System.Threading.Tasks;

using BackEnd.Data;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
     private readonly dbContext _context;
            public UsersController(dbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<User>> Adduser(User user) {
              _context.User.Add(user);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate(User user)
        {
            
            var usr =_context.User.Where(u => u.Email.Equals(user.Email)).Where(u=>u.Password.Equals(user.Password)).FirstOrDefault<User>();
                        if (usr == null)
                return BadRequest(new { message = "Nom ou prenom est incorrect" });

            return Ok(usr);
        }


    }
}