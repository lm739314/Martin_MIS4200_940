using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Martin_MIS4200_940.Models
{
    public class Grade
    {
        public int gradeID { get; set; }
        public string letterGrade { get; set; }

        public int studentID { get; set; }

        public int courseDetailID { get; set; }
        
        public virtual Student Student { get; set; }
        public virtual CourseDetail CourseDetail { get; set; }

        

    }
}