using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class Customer:Person
    {
        public int cusID; 
        public String companyName; 
        public String fax; 
        public int paymentAccountCode; 
        public int discountID; 

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