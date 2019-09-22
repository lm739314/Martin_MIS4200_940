using System;
using System.Collections.Generic;
using System.Data.Entity; //it addd this because we held alt period on DbContext and it said to add this
using System.Linq;
using System.Web;
using Martin_MIS4200_940.Models; //this must be added




namespace Martin_MIS4200_940.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set;}

    }

}