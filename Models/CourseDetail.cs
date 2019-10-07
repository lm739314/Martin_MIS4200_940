using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Martin_MIS4200_940.Models
{
    public class CourseDetail
    {
        [Display (Name = "Course Detail ID")]
        public int courseDetailID { get; set; }

        [Display(Name = "Description of Class")]
        [Required(ErrorMessage = "Description Required")]
        [StringLength(20)]
        public string description { get; set; }

        //setting up a foriegn key here. going back to one side
        [Display (Name = "Course ID")]
        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        //going to many side
        public ICollection<Grade> Grade { get; set;}
    }
}