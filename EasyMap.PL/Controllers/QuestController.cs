using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyMap.PL.Models;

namespace EasyMap.PL.Controllers
{
    public class QuestController : Controller
    {
        PageInfo pageInfo = PageInfo.Create("Quest");

        public ActionResult Create()
        {
            ViewBag.Page = pageInfo.setView("Create");
            return View();
        }

        public ActionResult Game()
        {
            ViewBag.Page = pageInfo.setView("Game");
            return View();
        }
    }
}