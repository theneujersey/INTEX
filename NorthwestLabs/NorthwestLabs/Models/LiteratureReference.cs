using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Literature_Reference")]
    public class LiteratureReference
    {
        [Key]
        public int litID { get; set; }

        [ForeignKey("Assay_ID")]
        public virtual int assayID { get; set; }
        public virtual Assay assay { get; set; }

        public String reference { get; set; }

        //methods
    }
}