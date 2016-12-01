using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    //this class is only for inheritance. These fields are shared by customer and employee, and could be used for others in the future
    public abstract class Person
    {
        public String firstName { get; set; } 
        public String lastName { get; set; } 
        public String address { get; set; } 
        public String city { get; set; } 
        public String state { get; set; } 
        public String zip { get; set; } 
        public String country { get; set; } 
        public String email { get; set; } 
        public String phone { get; set; } 
    }
}