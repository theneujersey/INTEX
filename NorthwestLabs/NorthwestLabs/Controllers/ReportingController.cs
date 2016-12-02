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
        // These are views for 'Process Summary Report' menu.
        public ActionResult ProcessSummaryReport()
        {
            return View();
        }

        public ViewResult ProcessSummaryReport2()
        {
            ViewBag.Confirmation = "The data report is successfully created. This will be notified to Seattle reporting department.";
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

        public ActionResult ProcessSummaryReport5()
        {
            return View();
        }

        // These are views for 'Process Data Report' menu.
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