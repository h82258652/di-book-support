﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex3_Unity.Controllers
{
    public class QooController : Controller
    {
        public QooController()
        {

        }

        public ActionResult Index()
        {
            return Content("Qoo");
        }
    }
}