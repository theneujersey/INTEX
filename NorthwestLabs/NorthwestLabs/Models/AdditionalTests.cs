﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Additional_Tests")]
    public class AdditionalTests
    {
        //linking class associates an assay for a work order with any additional test the customer has requested
        public WorkOrder workOrder { get; set; }
        public Assay assay { get; set; }
        public Test test { get; set; }

    }
}