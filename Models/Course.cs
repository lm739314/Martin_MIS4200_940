using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Martin_MIS4200_940.Models
{
    public class Course
    {
        [Display (Name = "Course ID")]
        public int courseID { get; set; }
        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Course Name Required")]
        [StringLength(20)]
        public string courseName { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Description Required")]
        [StringLength(20)]

        public string courseDescription { get; set; }

        [Display (Name = "Date/Time of Class")]
        [Required(ErrorMessage = "Date and Time Required")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime courseDateTime { get; set; }
        

        public ICollection<CourseDetail> CourseDetail { get; set; }
        //this will help us find pet
        //since pet is now a class, it can be considered a data type (see code below)
        //it will know which pet bc the petID from above
       

        //things get different here. There is a relationship between pet and appointment
    }
}