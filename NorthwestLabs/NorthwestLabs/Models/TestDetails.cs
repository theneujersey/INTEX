using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Test_Details")]
    public class TestDetails
    {
        //linking class associates tests with the materials required for a test

        public Materials materials { get; set; }
        public Test test { get; set; }
        public double quantity;

        //methods go here
    }
}