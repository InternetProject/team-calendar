﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calendar.Controllers
{
    public class MasterCalendarController : Controller
    {
        // GET: MasterCalendar
        public ActionResult Index()
        {
            return View();
        }
    }
}