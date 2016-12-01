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
        //linking class associates a work order's samlples with their assays
        public Sample sample { get; set; }
        public Assay assay { get; set; }
    }
}