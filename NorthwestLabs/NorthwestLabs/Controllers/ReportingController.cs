using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class ReportingController : Controller
    {
        // GET: Reporting
       

        public ActionResult ProcessBills7()
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

        public ViewResult ProcessSummaryReport2()
        {
            return View();
        }

        public ViewResult ProcessSummaryReport3()
        {
            return View();
        }

        public ActionResult ProcessSummaryReport4()
        {
            return View();
        }

        public ActionResult ProcessDataReport()
        {
            return View();
        }

        public ActionResult ProcessDataReport2()
        {
            return View();
        }

        public ActionResult ProcessDataReport3()
        {
            return View();
        }

        public ActionResult ProcessDataReport4()
        {
            return View();
        }
    }
}