using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        
        //CultureInfo Ci = CultureInfo.InvariantCulture;
        //private SqlDateTime _created = DateTime.ParseExact("01/01/1950", "MM/dd/yyyy", Ci);
        [Required]
        public DateTime StudentBirthdate 
        {
            //get { return _created.Value; }
            //set { _created = value == DateTime.MinValue ? SqlDateTime.MinValue : value; } 
            get; set;
        }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
