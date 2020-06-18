using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_MIME_Type.Models;
using System.Data.Entity;
namespace WebAPI_MIME_Type.Controllers
{
    public class EmployeeController : ApiController
    {
        CompanyContext db = new CompanyContext();

        public IHttpActionResult GetEmployees()
        {
            var emps = db.Employees.ToList();
            if (emps.Count > 0)
                return Ok(emps);
            return NotFound();
        }

        public IHttpActionResult GetEmployee(int id)
        {
            return Ok(db.Departments.ToList());
            //var emp = db.Employees.Find(id);
            //if (emp != null)
            //    return Ok(emp);
            //return NotFound();
        }

        public IHttpActionResult PostEmployee(Employee employee)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            db.Employees.Add(employee);
            db.SaveChanges();
            return Created("Done 100%", employee);
        }

        public IHttpActionResult PutEmployee([FromUri] int id,[FromBody] Employee employee)
        {
            if(ModelState.IsValid)
            {
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Ok(employee);
            }
            return BadRequest();
        }

        public IHttpActionResult DeleteEmployee(int id)
        {
            var emp = db.Employees.Find(id);
            if (emp is null)
                return NotFound();
            db.Employees.Remove(emp);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
