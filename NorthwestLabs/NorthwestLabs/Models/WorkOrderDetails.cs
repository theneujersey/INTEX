using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Work_Order_Details")]
    public class WorkOrderDetails
    {
        //linking class associates work orders with their details
        public WorkOrder workOrder { get; set; }
        public Assay assay { get; set; }
    }
}