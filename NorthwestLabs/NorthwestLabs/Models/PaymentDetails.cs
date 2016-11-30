using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class PaymentDetails
    {
        //linking class associates payments (or portions therof) to a work order
        public Payment payment { get; set; }
        public WorkOrder workOrder { get; set; } 

        public Double payPortion; 
    }
}