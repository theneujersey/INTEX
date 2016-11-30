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
        public String testID; 
        public String testName; 
        public String protocol; 
        public Double estimatedHours; 
        public Double basePrice; 

        //methods go here

    }
}