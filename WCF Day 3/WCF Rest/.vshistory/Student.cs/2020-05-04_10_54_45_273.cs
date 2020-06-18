using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Rest
{
    public class Student
    {
        [Key]
        public int SSN { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
    }
}
