using System;
using System.Collections.Generic;

namespace NS.EMS.Data.Entities
{
    public partial class EmployeeDept
    {
        public EmployeeDept()
        {
            Person = new HashSet<Person>();
        }

        public int EmployeeId { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
