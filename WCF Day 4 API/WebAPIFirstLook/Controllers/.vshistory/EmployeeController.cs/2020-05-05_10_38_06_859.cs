﻿using System;
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
            new Employee() { Id=4,Name="Lora",Age=24},
        };

        public List<Employee> GetEmployees()
        {
            return Employees;
        }


        public Employee GetEmployee(int id)
        {
            return Employees.Find(e => e.Id == id);
        }


    }
}
