using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult ProcessBills()
        {
            return View();
        }
        
        public ActionResult ProcessSummaryReport()
        {
            List<SelectListItem> workorder = new List<SelectListItem>();
            workorder.Add(new SelectListItem { Text = "Work Order 1", Value = "0" });
            workorder.Add(new SelectListItem { Text = "Work Order 2", Value = "1" });
            workorder.Add(new SelectListItem { Text = "Work Order 3", Value = "2" });
            ViewBag.WorkOrder = workorder;

            
            return View();
        }

        public ViewResult ProcessSummaryReport2(string WorkOrder)
        {
            if (WorkOrder.Equals("0"))
            {
               
            }

            else if (WorkOrder.Equals("1"))
            {
                
            }
            else if (WorkOrder.Equals("2"))
            {
               
            }


            else
                ViewBag.messageString = "Other";



            return View();
        }
    }
}