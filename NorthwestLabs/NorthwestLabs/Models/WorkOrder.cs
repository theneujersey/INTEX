using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class WorkOrder
    {
        public int woID;
        public String comments; 
        public String priority; 
        public DateTime completionDueDate; 
        public DateTime completionEstimatedDate; 
        public DateTime completionActualDate; 
        public Boolean discountVerified; 
        public Boolean invoiceVerified; 
        public DateTime invoiceSentDate; 
        public DateTime payDueDate; 
        public DateTime payEarlyDate; 
        public Double payEarlyDiscount; 

        public void enterOrderInfo(String sComments, String sPiriority, DateTime dtCompletionDueDate)
        {
            //code to update these items here
        }
    }

}