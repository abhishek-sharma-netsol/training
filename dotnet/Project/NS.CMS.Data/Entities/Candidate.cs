using System;
using System.Collections.Generic;

namespace NS.CMS.Data.Entities
{
    public partial class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Address { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Tech { get; set; } = null!;
        public string? Image { get; set; }
    }
}
