﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CurryKatsuCerritos.Controllers.Web
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "BOOM!";
            return View();
        }
    }
}
