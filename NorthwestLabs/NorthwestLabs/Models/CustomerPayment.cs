using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace NorthwestLabs.Models
{
    public class CustomerPayment
    {
        public Customer customer { get; set; }
        public Payment payment { get; set; }
    }
}