using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class Employee:Person
    {
        public int empID; 
        public String jobFunction; 
        public String hourlyWage; 

        //methods
        public Employee checkEmployeeInfo(String firstName, String lastName)
        {
            Employee myEmployee = new Employee();
            return myEmployee;
        }
    }
}