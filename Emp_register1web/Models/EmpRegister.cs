using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emp_register1web.Models
{
    public class EmpRegister
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [EmailAddress (ErrorMessage = "invalid Email Address")]
        public string Email { get; set; }

        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter Date")]
        [DataType (DataType.Date)]
        public DateTime DateOfJoining { get; set; } 
        [Required]
        public string Department { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
