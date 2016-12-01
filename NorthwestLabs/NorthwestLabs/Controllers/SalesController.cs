﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class SalesController : Controller
    {
        [HttpGet]
        public ActionResult CreateWorkOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateWorkOrder(FormCollection form)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("CreateWorkOrder2");
            }
            else
            {
                return View();
            }
            
        }

        //Second page of prototype: accepts samples
        public ActionResult CreateWorkOrder2()
        {
            return View();
        }
        
        //third page of prototype: review and finalize
        public ActionResult CreateWorkOrder3()
        {
            return View();
        }

        //third page of prototype: print
        public ActionResult CreateWorkOrder4()
        {
            return View();
        }
    }
}