﻿using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class AccessController : Controller
    {
        QlbanVaLiContext  db = new QlbanVaLiContext();
        [HttpGet]
        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("Username")==null)
            {
                return View();
            } else
            {
                return RedirectToAction("Index","Home");
            }
        }
        [HttpPost]
        public IActionResult Login(TUser user)
        {
            if(HttpContext.Session.GetString("UserName")==null)
            {
                var u = db.TUsers.Where(x=>x.Username.Equals(user.Username)&&
                x.Password.Equals(user.Password)).FirstOrDefault();

                if(u!=null)
                {
					if (u.LoaiUser == 0)
					{
						return RedirectToAction("Index", "Home");

					} else
                    {
						HttpContext.Session.SetString("UserName", u.Username.ToString());
						return RedirectToAction("Index", "HomeAdmin", new {Area="Admin"});
					}
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("Login", "Access");
        }
    }
}
