using System;
using System.Collections.Generic;

namespace WebAppCore1.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal? Salary { get; set; }
        public int DeptId { get; set; }

        public virtual Departments Dept { get; set; }
    }
}
