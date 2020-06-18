using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI_MIME_Type.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }
        public virtual Department Department { get; set; }
    }
}