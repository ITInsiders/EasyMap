using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyMap.PL.Models;

namespace EasyMap.PL.Controllers
{
    public class HomeController : Controller
    {
        PageInfo pageInfo = PageInfo.Create("Home");

        public ActionResult Index()
        {
            ViewBag.Page = pageInfo.setView("Index");
            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Page = pageInfo.setView("Search");
            return View();
        }

        public ActionResult Identifier()
        {
            ViewBag.Page = pageInfo.setView("Identifier");
            return View();
        }
    }
}