using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIFirstLook.Models;

namespace WebAPIFirstLook.Controllers
{
    public class EmployeeController : ApiController
    {
        static List<Employee> Employees = new List<Employee>()
        {
            new Employee() { Id=1,Name="Sara",Age=22},
            new Employee() { Id=2,Name="Ali",Age=21},
            new Employee() { Id=3,Name="Ola",Age=23},
            new Employee() { Id=4,Name="Lora",Age=24}
        };

        //public List<Employee> GetEmployees()
        //{
        //    return Employees;
        //}

        //public Employee GetEmployee(int id)
        //{
        //    return Employees.Find(e => e.Id == id);
        //}

        public IHttpActionResult GetEmployees()
        {
            var emps = Employees;
            if(emps.Count > 0)
            {
                //Enforce response status 200 ok
                return Ok(emps);
            }
            return NotFound();
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var emps = Employees.FirstOrDefault(e => e.Id == id);
            if (emps != null)
            {
                //Enforce response status 200 ok
                return Ok(emps);
            }
            return NotFound();
        }

        public IHttpActionResult PostEmployee(Employee employee)
        {
            Employees.Add(employee);
            return StatusCode(HttpStatusCode.NoContent);
            //return Created("Created Successfully", employee);
            //return Ok(employee);
        }

        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            var emp = Employees.FirstOrDefault(e => e.Id == id);
            emp.Id = employee.Id;
            emp.Name = employee.Name;
            emp.Age = employee.Age;
            return Ok(Employees);
        }

    }
}
