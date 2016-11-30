using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class AssayDetails
    {
        public Assay assay { get; set; }
        public Test test { get; set; }

        public String condition;
    }
}