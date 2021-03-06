﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Test_Tube")]
    public class TestTube
    {
        [Key]
        [DisplayName("Test Tube Number")]
        public int ttNumber { get; set; }
        public int concentration { get; set; }
        [DisplayName("Quantitative Result File")]
        public String quantitativeResult { get; set; }
        [DisplayName("Qualitative Result File")]
        public String qualitativeResult { get; set; }
        public Double customDiscount { get; set; }
        public int actualHours { get; set; }
        [DisplayName("Comments")]
        public String comments { get; set; }
        [DisplayName("Charge")]
        public Double charge { get; set; }

        [ForeignKey("Sample_ID")]
        public virtual int sampleID { get; set; }
        public virtual Sample sample { get; set; }

        [ForeignKey("Test_ID")]
        public virtual int testID { get; set; }
        public virtual Test test { get; set; }

        //  methods 
        public void enterAllCharges(int[] TTNumber, Double[] Amount)
        {
            //method code here
        }
        public void enterTestTubeInfo(int iLTNumber, int iCompoundSequenceCode,  int iConcentration, String sTestID)
        {
            //method code here
        }
        public void createNewDataReport(int iWoID)
        {
            //method code here
        }
        public void updateDataReport(int iWoID, String sDescription)
        {
            //method code here
        }
        public void createNewSummaryReport(int iTTNumberString, String sQualitativeResult, String sQuantitativeResult, int iActualHours)
        {
            //method code here
        }
    }
}