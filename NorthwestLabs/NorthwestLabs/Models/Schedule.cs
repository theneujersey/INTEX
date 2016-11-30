using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class Schedule
    {
        //attributes
        public int empID; 
        public int ttNumber; 
        public DateTime startDate; 
        public DateTime completionEstimatedDate; 
        public DateTime completionActualDate; 

        //methods
        public ArrayList requestExcelSpreadsheet()
        {
            ArrayList myArrayList = new ArrayList();

            return myArrayList;
        }
        public void inputExpectedCompletionDate(int iWoID, DateTime dtExpectedCompletionDate)
        {
            //method code here
        }
        public void beginTest(int iEmpID, int iTTNumber)
        {
            //method code here
        }
        public void closeTest(int iEmpID, int iTTNumber)
        {
            //method code here
        }
    }
}