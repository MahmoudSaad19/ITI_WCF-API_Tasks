using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore1.Models.Repository
{
    public class EmpDBRepo:IEmpRepo
    {
        APICompanyContextContext db;

        public EmpDBRepo(APICompanyContextContext context)
        {
            db = context;
        }

        public List<Employees> GetEmployees()
        {
            return db.Employees.ToList();
        }

        public Employees GetEmployees(int id)
        {
            return db.Employees.Find(id);
        }

        public void add (Employees employees)
        {
            db.Employees.Add(employees);
            db.SaveChanges();
        }

        public void edit(Employees employees)
        {
            db.Entry(employees).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void delete(int id)
        {
            db.Employees.Remove(db.Employees.Find(id));
            db.SaveChanges();
        }
    }
}
