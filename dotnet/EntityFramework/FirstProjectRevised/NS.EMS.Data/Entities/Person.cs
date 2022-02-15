using System;
using System.Collections.Generic;

namespace NS.EMS.Data.Entities
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int? EmployeeId { get; set; }

        public virtual EmployeeDept Employee { get; set; }
    }
}
