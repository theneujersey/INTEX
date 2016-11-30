using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class TestDetails
    {
        public Materials materials { get; set; }
        public Test test { get; set; }
        public double quantity;

        //methods go here
    }
}