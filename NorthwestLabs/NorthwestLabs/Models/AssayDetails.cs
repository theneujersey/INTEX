using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    //linking class associates tests with the assays they are run on
    [Table("Assay_Details")]
    public class AssayDetails
    {
        public Assay assay { get; set; }
        public Test test { get; set; }

        public String condition;
    }
}