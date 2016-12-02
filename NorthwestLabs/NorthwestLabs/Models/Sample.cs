using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int sampleID { get; set; } 
        public int compoundSequenceCode { get; set; } 
        public DateTime arrivedDate { get; set; } 
        public DateTime confirmationDate { get; set; } 
        [DisplayName("Appearance")]
        public String appearance { get; set; }
        [DisplayName("Quantity")]
        public Double quantity { get; set; } 
        [DisplayName("Molecular Mass")]
        public Double molecularMass { get; set; }
        [DisplayName("Customer Weight")]
        public Double customerWeight { get; set; }
        [DisplayName("Actual Weight")]
        public Double actualWeight { get; set; }
        [DisplayName("Maximum Tolerated Dose")]
        public Double maximumToleratedDose { get; set; }

        [ForeignKey("Emp_ID")]
        public virtual int empID { get; set; }
        public virtual Employee employee { get; set; }

        [ForeignKey("WO_ID")]
        public virtual int woID { get; set; }
        public virtual WorkOrder workOrder { get; set; }

        [ForeignKey("Com_ID")]
        public virtual int comID { get; set; }
        public virtual Compound compound { get; set; }

        [ForeignKey("Assay_ID")]
        public virtual int assayID { get; set; }
        public virtual Assay assay { get; set; }

        //add methods here
    }
}