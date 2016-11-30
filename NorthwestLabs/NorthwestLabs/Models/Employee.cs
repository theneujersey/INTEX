using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Employee")]
    public class Employee:Person
    {
        [Key]
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