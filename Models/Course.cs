using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Martin_MIS4200_940.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string courseName { get; set; }

        public string courseDescription { get; set; }

        public DateTime courseDateTime { get; set; }
        

        public ICollection<CourseDetail> CourseDetail { get; set; }
        //this will help us find pet
        //since pet is now a class, it can be considered a data type (see code below)
        //it will know which pet bc the petID from above
        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        //things get different here. There is a relationship between pet and appointment
    }
}