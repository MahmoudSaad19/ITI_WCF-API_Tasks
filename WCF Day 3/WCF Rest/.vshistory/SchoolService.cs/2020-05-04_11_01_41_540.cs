using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Rest
{
    public class SchoolService : IStudentService
    {
        SchoolContext dbContext = new SchoolContext();
        public void Add(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbContext.Students.Remove(dbContext.Students.Find(id));
            dbContext.SaveChanges();
        }

        public void Edit(Student student)
        {
            dbContext.Entry(student).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            return dbContext.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return dbContext.Students.ToList();
        }
    }
}
