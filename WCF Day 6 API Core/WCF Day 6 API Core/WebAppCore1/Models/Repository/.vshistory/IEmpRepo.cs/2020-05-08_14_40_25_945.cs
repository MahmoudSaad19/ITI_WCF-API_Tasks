using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore1.Models.Repository
{
    public interface IEmpRepo
    {
        List<Employees> GetEmployees();

        Employees GetEmployees(int id);

        void add(Employees employee);
    }
}
