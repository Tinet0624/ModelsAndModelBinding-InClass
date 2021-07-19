using System;
using System.Collections.Generic;
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
        public string FullName { get; set; }
        /// <summary>
        /// The M/D/Y time is ignored
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Student email address
        /// ex: jane.doe@cptc.edu
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Students primary phone number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
