using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Work_Order")]
    public class WorkOrder
    {
        [Key]
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

        [ForeignKey("Emp_ID")]
        public virtual int empID { get; set; }
        public virtual Employee employee { get; set; }

        [ForeignKey("Cus_ID")]
        public virtual int cusID { get; set; }
        public virtual Customer customer { get; set; }


        public void enterOrderInfo(String sComments, String sPiriority, DateTime dtCompletionDueDate)
        {
            //code to update these items here
        }
    }

}