using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Sample")]
    public class Sample
    {
        [Key]
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

        [ForeignKey("Emp_ID")]
        public virtual int empID { get; set; }
        public virtual Employee employee { get; set; }

        [ForeignKey("WO_ID")]
        public virtual int woID { get; set; }
        public virtual WorkOrder workOrder { get; set; }

        [ForeignKey("Com_ID")]
        public virtual int comID { get; set; }
        public virtual Compound compound { get; set; }

        //add methods here
    }
}