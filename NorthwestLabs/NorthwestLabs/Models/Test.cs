using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public String testID { get; set; } 
        public String testName { get; set; } 
        public String protocol { get; set; } 
        public Double estimatedHours { get; set; } 
        public Double basePrice { get; set; } 

        //methods go here

    }
}