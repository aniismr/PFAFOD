
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using BackEnd.Data;

using System;
using System.Text.Json;
using Microsoft.Net.Http.Headers;
namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourcesController : ControllerBase
    {
        [HttpPost, DisableRequestSizeLimit]
        public IActionResult Post()
        {
            try
    {
        var file = Request.Form.Files[0];
        var folderName = Path.Combine("Resources", "Images");
        var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
 
        if (file.Length > 0)
        {
            var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim();
            var fullPath = Path.Combine(pathToSave, fileName.ToString());
            var dbPath = Path.Combine(folderName, fileName.ToString());
            var fname=fileName.ToString();
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
           
            return Ok(new {fname});

        }
        else
        {
            return BadRequest();
        }
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"Internal server error: {ex}");
    }
          
           

         
        }
      [HttpPost("CV"), DisableRequestSizeLimit]
        public IActionResult PostCV(){
             try
    {
        var file = Request.Form.Files[0];
        var folderName = Path.Combine("Resources", "CV");
        var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
 
        if (file.Length > 0)
        {
            var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim();
            var fullPath = Path.Combine(pathToSave, fileName.ToString());
            var dbPath = Path.Combine(folderName, fileName.ToString());
            var fname=fileName.ToString();
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
           
            return Ok(new {fname});

        }
        else
        {
            return BadRequest();
        }
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"Internal server error: {ex}");
    }
        }
    }
}
