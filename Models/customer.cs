using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Martin_MIS4200_940.Models
{
    public class customer
    {
        //define feild we want in customer
        // "prop tab tab" will get us the code below
        //name of the key is important 1. We name it ID and it assumes it to be the primary key 2. Name of class followed by ID and assumes to be primary key
        //get will allow us to read value somewhere else. Set will allow us to asign a value
        public int customerID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        //we created this one below after we made the order class

        public string fullName { get
            {
                return lastName + ", " + firstName;
            }
        }
        //we dont have any need to see the customer ID, we wont recognigze it. we would like to see the name
        //read only property, we dont need set. 
        public ICollection<order> orders { get; set; }
        //all orders for customers in a collection so we can loop over
        //when we look at a customer, we will be able to view all the orders for a specific customer
    }
}