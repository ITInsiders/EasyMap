﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyMap.BL.DTO;
using EasyMap.BL.Services;


namespace EasyMap
{
    public class Identity
    {
        private HttpContext HC => HttpContext.Current;
        public UserDTO user = null;

        public bool Authentication(string Login, string Password)
        {
            if (HC.Request.Cookies["User"] != null) { HC.Response.Cookies["User"].Expires = DateTime.Now.AddYears(-1); user = null; }

            bool Answer = CheckUserData(Login, Password);
            if (Answer)
            {
                HttpCookie User = new HttpCookie("User");
                User.Expires = DateTime.Now.AddYears(1);

                User["Login"] = Login.ToUpper();
                User["Password"] = Password;

                HC.Response.Cookies.Add(User);
            }
            return Answer;
        }

        public bool isAuthentication
        {
            get
            {
                if (HC.Request.Cookies["User"] == null) { user = null; return false; }
                else
                {
                    string Login = HC.Request.Cookies["User"]["Login"];
                    string Password = HC.Request.Cookies["User"]["Password"];
                    return CheckUserData(Login, Password);
                }
            }
        }

        public void ResetAuthentication()
        {
            if (HC.Request.Cookies["User"] != null)
            { HC.Response.Cookies["User"].Expires = DateTime.Now.AddYears(-1); user = null; }
        }

        public bool CheckUserData(string Login, string Password)
        {
            user = UserServices.GetAll().FirstOrDefault(x => x.Login == Login && x.Password == Password);
            return user != null;
        }
    }
}