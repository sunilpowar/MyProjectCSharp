using System;
using System.Reflection;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Annotations
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee {0} is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should be 3 Characters and Maximum of 100 characters")]
        [DataType(DataType.Text)]

        public string Name { get; set; }


        [Range(10, 99, ErrorMessage = "Age should be above 18")]
        public int Age { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }


        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }



    }
   
}
