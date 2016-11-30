
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{

    public class Discounts
    {
       
        //stores discount rates for certain volumes of orders
        public int discountID; 
        public int minimumVolume; 
        public Double discountFactor; 
    }
}