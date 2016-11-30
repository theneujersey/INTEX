using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class Sample
    {
        public int sampleID; 
        public int compoundSequenceCode; 
        public DateTime arrivedDate; 
        public DateTime confirmationDate; 
        public String appearance; 
        public Double quantitiy; 
        public Double molecularMass; 
        public Double customerWeight; 
        public Double actualWeight; 
        public Double maximumToleratedDose;  

        //add methods here
    }
}