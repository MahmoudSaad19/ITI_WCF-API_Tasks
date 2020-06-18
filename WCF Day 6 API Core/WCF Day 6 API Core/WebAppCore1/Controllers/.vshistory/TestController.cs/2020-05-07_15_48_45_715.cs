using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppCore1.Models;

namespace WebAppCore1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        ITIContext db;

        public TestController(ITIContext iTIContext)
        {
            db = iTIContext;
        }

        public IActionResult getAll()
        {
            return Ok(db.Student.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult getByID(int id)
        {
            return Ok(db.Student.Find(id));
        }
    }
}