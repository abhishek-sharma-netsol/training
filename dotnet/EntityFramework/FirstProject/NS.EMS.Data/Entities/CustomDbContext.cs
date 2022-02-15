using Microsoft.EntityFrameworkCore;
using NS.EMS.Model;

namespace NS.EMS.Data.Entities
{

    public partial class EmployeeDBContext : DbContext
    {
        public virtual DbSet<EmployeeDeptModel> EmpDpt { get; set; }
    }
}
