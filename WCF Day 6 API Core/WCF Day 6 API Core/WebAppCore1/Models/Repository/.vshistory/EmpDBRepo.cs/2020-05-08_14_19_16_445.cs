using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore1.Models.Repository
{
    public class EmpRepo
    {
        APICompanyContextContext _context;

        public EmpRepo(APICompanyContextContext context)
        {
            _context = context;
        }


    }
}
