using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_MIME_Type.Models;

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
            var emp = db.Employees.Find(id);
            if (emp != null)
                return Ok(emp);
            return NotFound();
        }

        public IHttpActionResult PostEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                return BadRequest();
            }
            db.Employees.Add(employee);
            db.SaveChanges();
            return Ok();
        }
    }
}
