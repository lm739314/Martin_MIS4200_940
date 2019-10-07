using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Martin_MIS4200_940.Models
{
    public class Grade
    {
       
        [Display (Name = "Grade")]
        public int gradeID { get; set; }

        [Display(Name = "Letter Grade")]
        [Required(ErrorMessage = "Letter Grade Required")]
        [StringLength(20)]
        public string letterGrade { get; set; }

        [Display (Name = "Student ID")]
        public int studentID { get; set; }


        [Display(Name = "Course Detail")]
       
        public int courseDetailID { get; set; }
        
        public virtual Student Student { get; set; }
        public virtual CourseDetail CourseDetail { get; set; }

        

    }
}