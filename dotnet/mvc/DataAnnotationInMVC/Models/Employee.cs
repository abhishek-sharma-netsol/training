using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationInMVC.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        [Required(ErrorMessage="FirstName is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="LastName is required.")]
        public string LastName { get; set; }

        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter a valid email address")]
        public string EmailId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string URL { get; set; }
    }
}
