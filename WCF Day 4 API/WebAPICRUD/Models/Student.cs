namespace WebAPICRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [Key]
        public string SSN { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }
}
