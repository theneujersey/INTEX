using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.Models;

namespace NorthwestLabs.Controllers
{
    public class TestingController : Controller
    {
        // GET: Testing
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RunAssays1()
        {
            return View();
        }

        public ActionResult RunAssays2()
        {
            return View();
        }

        public ActionResult RunAssays3()
        {
            return View();
        }

        public ActionResult RunAssays4()
        {
            return View();
        }

        public ActionResult ScheduleAssays1()
        {
            return View();
        }

        public ActionResult ScheduleAssays2()
        {
            return View();
        }

        public ActionResult ScheduleAssays3()
        {
            return View();
        }
        public ActionResult ReceiveCompound1()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReceiveCompound1(Compound compound)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ReceiveCompound2");
            }
            else
            {
                return View(compound);
            }
            
        }

        public ActionResult ReceiveCompound2()
        {
            return View();
        }

        public ActionResult ReceiveCompound3()
        {
            return View();
        }

        public ActionResult Solubilize()
        {
            return View();
        }

        public ActionResult Solubilize1()
        {
            return View();
        }

        public ActionResult Solubilize2()
        {
            return View();
        }
    }
}