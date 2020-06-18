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
        public ActionResult<Student> getByID(int id)
        {
            var std = db.Student.Find(id);
            if (std is null)
                return NotFound();
            return std;
        }

        public ActionResult add (Student student)
        {
            db.Student.Add(student);
            db.SaveChanges();
            return Created("ok", student);
        }
    }
}