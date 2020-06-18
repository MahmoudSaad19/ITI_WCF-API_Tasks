using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore1.Models.Repository
{
    public class EmpRepo
    {
        APICompanyContextContext db;

        public EmpRepo(APICompanyContextContext context)
        {
            db = context;
        }

        public List<Employees> GetEmployees()
        {
            return 
        }
    }
}
