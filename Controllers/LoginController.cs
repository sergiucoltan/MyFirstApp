﻿using MyFirstApp.Models;
using MyFirstApp.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login"); 
        }

        public ActionResult Login(UserModel userModel)
        {
            /*return "Results: Username = " + userModel.Username + " PW = " + userModel.Password;*/
            SecurityService securityService = new SecurityService();
            Boolean success = securityService.Authenticate(userModel);

            if (success)
            {
                return View("LoginSuccess", userModel);

            }
            else
            {
                return View("LoginFailure");

            }
        }
    }
}