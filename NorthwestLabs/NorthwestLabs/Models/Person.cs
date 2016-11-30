using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    //this class is only for inheritance. These fields are shared by customer and employee, and could be used for others in the future
    public abstract class Person
    {
        public String firstName; 
        public String lastName; 
        public String address; 
        public String city; 
        public String state; 
        public String zip; 
        public String country; 
        public String email; 
        public String phone; 
    }
}