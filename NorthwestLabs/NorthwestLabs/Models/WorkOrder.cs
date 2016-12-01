using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int woID { get; set; }
        [Required]
        public String comments { get; set; } 
        public String priority { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("requested due date")]
        public DateTime completionDueDate { get; set; }
        public DateTime completionEstimatedDate { get; set; } 
        public DateTime completionActualDate { get; set; } 
        public Boolean discountVerified { get; set; } 
        public Boolean invoiceVerified { get; set; } 
        public DateTime invoiceSentDate { get; set; } 
        public DateTime payDueDate { get; set; } 
        public DateTime payEarlyDate { get; set; } 
        public Double payEarlyDiscount { get; set; }

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