using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore1.Models.Repository
{
    public class EmplistRepo:IEmpRepo
    {
        static List<Employees> Employees = new List<Employees>()
        {
            new Employees() { Id=1,Name="Aya",Age=22,Salary=3000},
            new Employees() { Id=2,Name="Ola",Age=21,Salary=2000},
            new Employees() { Id=3,Name="Doaa",Age=23,Salary=4000},
            new Employees() { Id=4,Name="Ali",Age=25,Salary=5000}
        };       

        public List<Employees> GetEmployees()
        {
            return Employees;
        }

        public Employees GetEmployees(int id)
        {
            return Employees.Find(e => e.Id == id);
        }

        public void add(Employees employee)
        {
            Employees.Add(employee);
        }

        public void edit(Employees employee)
        {
            var emp = Employees.Find(e => e.Id == employee.Id);
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Age = employee.Age;
            emp.DeptId = employee.DeptId;
        }

        public void delete(int id)
        {
            Employees.RemoveAll(e => e.Id == id);
        }
    }
}
