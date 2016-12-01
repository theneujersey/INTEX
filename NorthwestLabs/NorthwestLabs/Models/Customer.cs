using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Customer")]
    public class Customer:Person
    {
        [Key]
        [DisplayName("Customer ID")]
        public int cusID { get; set; }
        public String companyName { get; set; }
        public String fax { get; set; }
        public int paymentAccountCode { get; set; }

        [ForeignKey("Dis_ID")]
        public virtual int discountID { get; set; }
        public virtual Discounts discount { get; set; } 

        //methods
        public Customer checkCustomerInfo(String sCompanyName)
        {
            Customer myCustomer = new Customer();

            return myCustomer;
        }
        public Customer checkCustomerInfo(int iCusID)
        {
            Customer myCustomer = new Customer();

            return myCustomer;

        }

    }
}