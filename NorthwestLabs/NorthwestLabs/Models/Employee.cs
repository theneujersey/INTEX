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
        public int empID { get; set; }
        public String jobFunction { get; set; }
        public String hourlyWage { get; set; }

        //methods
        public Employee checkEmployeeInfo(String firstName, String lastName)
        {
            Employee myEmployee = new Employee();
            return myEmployee;
        }
    }
}