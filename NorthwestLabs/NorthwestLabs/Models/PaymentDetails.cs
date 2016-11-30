using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Payment_Details")]
    public class PaymentDetails
    {
        //linking class associates payments (or portions therof) to a work order
        public Payment payment { get; set; }
        public WorkOrder workOrder { get; set; } 

        public Double payPortion; 
    }
}