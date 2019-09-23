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

        //setting up a foriegn key here. going back to one side
        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        //going to many side
        public ICollection<Grade> Grade { get; set;}
    }
}