using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyMap.PL.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        public ActionResult Place()
        {
            string Name = Request.Form.Get("Name");
            string Address = Request.Form.Get("Address");
            string Site = Request.Form.Get("Site");
            string Phone = Request.Form.Get("Phone");
            string WorkingHour = Request.Form.Get("WorkingHour");
            string TimeFrom = Request.Form.Get("TimeFrom");
            string TimeTo = Request.Form.Get("TimeTo");
            string dayAndNight = Request.Form.Get("dayAndNight");
            string BreakTimeFrom = Request.Form.Get("BreakTimeFrom");
            string BreakTimeTo = Request.Form.Get("BreakTimeTo");
            string Nonstop = Request.Form.Get("Nonstop");
            string Description = Request.Form.Get("Description");
            string Photo = Request.Form.Get("Photo");
            
            return View();
        }
    }
}