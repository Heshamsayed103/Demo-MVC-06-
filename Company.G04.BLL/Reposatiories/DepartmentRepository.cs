using Company.G04.BLL.Interfaces;
using Company.G04.DAL.Data.Contexts;
using Company.G04.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G04.BLL.Reposatiories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepratmentRepository
    {
        public DepartmentRepository(CompanyDbContext context) : base(context)
        {
            
        }

    }
}
