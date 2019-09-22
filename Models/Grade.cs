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
        

        public ICollection<CourseDetail> CourseDetail { get; set; }

    }
}