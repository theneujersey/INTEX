using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Assay")]
    //holds the various assays we run
    public class Assay
    {
        [Key]
        public int assayID; 
        public String assayName; 
    }
}