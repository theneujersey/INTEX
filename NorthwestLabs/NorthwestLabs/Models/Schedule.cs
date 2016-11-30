using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Schedule")]
    public class Schedule
    {
        //attributes
        [Key]
        public int empID;
        public virtual Employee employee { get; set; }

        [Key]
        public int ttNumber;
        public virtual TestTube testTube { get; set; }

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