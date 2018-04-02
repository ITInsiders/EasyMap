using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyMap.PL.Models;
using EasyMap.BL.DTO;
using EasyMap.BL.Services;

namespace EasyMap.PL.Controllers
{
    public class AccountController : Controller
    {
        PageInfo pageInfo = PageInfo.Create("Account");
        Identity Identity = new Identity();

        public ActionResult Account()
        {
            ViewBag.Page = pageInfo.setView("Account");
            return View();
        }

        [HttpPost]
        public ActionResult Entry(UserDTO Model)
        {
            if (Identity.Authentication(Model.Login, Model.Password)) return Redirect("/Home");
            else ModelState.AddModelError("Password", "Пароль не верный");

            return View();
        }

        [HttpPost]
        public ActionResult Registration(UserRegistration Model)
        {
            UserServices.Create(Model);
            if (Identity.Authentication(Model.Login, Model.Password)) return Redirect("/Home");

            return View();
        }

        public ActionResult Exit()
        {
            Identity.ResetAuthentication();
            return Redirect(Request.UrlReferrer.AbsoluteUri);
        }

        public JsonResult Authentication()
        {
            return Json(Identity.isAuthentication, JsonRequestBehavior.AllowGet);
        }
    }
}