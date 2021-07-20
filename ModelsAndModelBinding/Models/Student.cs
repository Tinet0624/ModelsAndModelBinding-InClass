using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// represents an individual Student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// ID that identifies a Student
        /// </summary>
        public int StudentID { get; set; }
        /// <summary>
        /// The legal First and Last name of the student
        /// </summary>
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Enter your Full Name.")]
        public string FullName { get; set; }
        /// <summary>
        /// The M/D/Y time is ignored
        /// </summary>
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Student email address
        /// ex: jane.doe@cptc.edu
        /// </summary>
        [Display(Name = "Student Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// Students primary phone number
        /// </summary>
        [Display(Name = "Primary Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
