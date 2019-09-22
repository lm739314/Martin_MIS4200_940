using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Martin_MIS4200_940.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }

        public string description { get; set; }


        public int courseID { get; set; }
        public virtual Course Course { get; set; }


        public int gradeID { get; set; }
        public virtual Grade Grade { get; set;}
    }
}