using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_MIME_Type.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [Key]
        public int DeptId { get; set; }
        public int DeptName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}