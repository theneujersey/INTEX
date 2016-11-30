using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int payID; 

        [ForeignKey("Cus_ID")]
        public virtual int cusID { get; set; }
        public virtual Customer customer { get; set; }

        public DateTime date; 
        public Double amount;
 
        //add methods here
    }
}