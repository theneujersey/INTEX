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
        public int payID { get; set; }

        [ForeignKey("Cus_ID")]
        public virtual int cusID { get; set; }
        public virtual Customer customer { get; set; }

        public DateTime date { get; set; }
        public Double amount { get; set; }
 
        //add methods here
    }
}