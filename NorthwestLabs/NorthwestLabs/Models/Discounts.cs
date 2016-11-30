
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Discounts")]
    public class Discounts
    {
       
        //stores discount rates for certain volumes of orders
        [Key]
        public int discountID; 
        public int minimumVolume; 
        public Double discountFactor; 
    }
}