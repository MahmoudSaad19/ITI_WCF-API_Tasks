using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppCore1.Models;
using WebAppCore1.Models.Repository;

namespace WebAppCore1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        EmpDBRepo repo;
        EmplistRepo emplist;

        public EmpsController(EmpDBRepo emp, EmplistRepo emplistRepo)
        {
            repo = emp;
            emplist = emplistRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employees>> GetEmployees()
        {
            return emplist.GetEmployees();
        }

        [HttpGet("{id}")]
        public ActionResult<Employees> GetEmployees(int id)
        {
            return repo.GetEmployees(id);
        }
    }
}