using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPICRUD.Models;

namespace WebAPICRUD.Controllers
{
    public class StudentController : ApiController
    {
        CompanyContext db = new CompanyContext();

        public IHttpActionResult GetStudents()
        {
            var stds = db.Students.ToList();
            if(stds.Count > 0)
            {
                return Ok(stds);
            }
            return NotFound();
        }

        public IHttpActionResult GetStudent(string id)
        {
            var std = db.Students.FirstOrDefault(e => e.SSN == id);
            if (std != null)
            {
                return Ok(std);
            }
            return NotFound();
        }

        public IHttpActionResult PostStudent(Student student)
        {
            if (student != null)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return Created("Created Success", student);
            }
            return BadRequest("Data is incomplete");
        }

        public IHttpActionResult PutStudent(string id, Student student)
        {
            if (student != null)
            {
                var oldstd = db.Students.FirstOrDefault(s => s.SSN == id);
                if(oldstd == null)
                {
                    return NotFound();
                }
                oldstd.Name = student.Name;
                db.SaveChanges();
                return Ok(db.Students);
            }
            return BadRequest("Data is incomplete");
        }

        public IHttpActionResult DeleteStudent(int id)
        {
            var std = db.Students.Find(id);
            if(std is null)
            {
                return NotFound();
            }
            db.Students.Remove(std);
            db.SaveChanges();
            return Ok(db.Students);
        }
    }
}
