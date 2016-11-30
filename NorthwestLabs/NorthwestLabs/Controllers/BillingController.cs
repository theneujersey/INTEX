using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class BillingController : Controller
    {
        // GET: Billing
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProcessBills()
        {
            return View();
        }

        public ActionResult ProcessBills2()
        {
            return View();
        }

        public ActionResult ProcessBills3()
        {
            return View();
        }

        public ActionResult ProcessBills4()
        {
            return View();
        }

        public ActionResult ProcessBills5()
        {
            return View();
        }

        public ActionResult ProcessBills6(int id)
        {
            if (id == 0)
            {
                ViewBag.Message = "The customer has multiple work orders, so multiple invoices will be required.";
            }
            else
            {
                ViewBag.Message = "Nothing";
            }
            return View();
        }

        public ActionResult ProcessBills7()
        {
            return View();
        }
    }
}