using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class WorkOrderSchedule
    {
        public WorkOrder workOrder { get; set; }
        public Schedule schedule { get; set; }
    }
}