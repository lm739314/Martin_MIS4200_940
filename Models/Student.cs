using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Martin_MIS4200_940.Models
{
    public class Student
    {
        //define feild we want in pet
        // "prop tab tab" will get us the code below
        //name of the key is important 1. We name it ID and it assumes it to be the primary key 2. Name of class followed by ID and assumes to be primary key
        //get will allow us to read value somewhere else. Set will allow us to asign a value

        [Display (Name = "Student ID")]
        public int studentID { get; set; }

        [Display (Name = "Student Last Name")]
        [Required (ErrorMessage = "Last Name Required")]
        [StringLength(20)]

        public string lastName { get; set; }

        [Display(Name = "Student First Name")]
        [Required(ErrorMessage = "First Name Required")]
        [StringLength(20)]


        public string firstName { get; set; }

        [Display(Name = "Student Ohio Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Please enter Ohio University Email")]
        public string email { get; set; }

        [Display (Name = "Mobile phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone Numbers Must Be In The Format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        
        //we created this one below after we made the appointment class

            //a pet can have many appointments, a doc can have many appointments, a pet can have one doc

        [Display (Name = "Student Full Name")]
        public string fullName { get
            {
                return firstName + " " + lastName;
            }
        }
        //we dont have any need to see the pet ID, we wont recognigze it. we would like to see the name
        //read only property, we dont need set. 
        public ICollection<Grade> Grades { get; set; }
        //all appointments for pet in a collection so we can loop over
        //when we look at a pet, we will be able to view all the orders for a specific customer
    }

}