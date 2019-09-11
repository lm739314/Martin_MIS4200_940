using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Martin_MIS4200_940.Models
{
    public class order
    {
        public int orderID { get; set; }
        public int customerID { get; set; }
        //this will help us find customer
        //since customer is now a class, it can be considered a data type (see code below)
        //it will know which customer bc the customerID from above
        public customer customer { get; set; }
        public DateTime orderDate { get; set; }

        //things get different here. There is a relationship between customer and order
    }
}