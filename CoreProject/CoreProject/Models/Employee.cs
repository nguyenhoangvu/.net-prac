using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreProject.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter first name it is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name it is required")]
        public string LastName { get; set; }
        [MaxLength(5)]
        public string EmpCode { get; set; }
        public string Position { get; set; }
    }
}
