using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class TestTube
    {
        public int ttNumber; 
        public int concentration; 
        public String quantitativeResult; 
        public String qualitativeResult; 
        public Double customDiscount; 
        public int actualHours; 
        public String comments; 
        public Double charge; 

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