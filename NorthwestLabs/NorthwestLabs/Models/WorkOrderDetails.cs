using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class WorkOrderDetails
    {
        //linking class associates work orders with their details
        public WorkOrder workOrder { get; set; }
        public Assay assay { get; set; }
    }
}