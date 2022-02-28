using System;
using System.Collections.Generic;

namespace NS.EMS.API.Entities
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirtName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
    }
}
