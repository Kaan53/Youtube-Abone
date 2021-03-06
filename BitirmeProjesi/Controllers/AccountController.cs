﻿using BitirmeProjesi.DBModel;
using BitirmeProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitirmeProjesi.Controllers
{
    public class AccountController : Controller
    {
        UserDBEntities objUserDBEntities = new UserDBEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            UserModel objUserModel = new UserModel();
            return View(objUserModel);
        }
        [HttpPost]
        public ActionResult Register(UserModel objuserModel)
        {
            if (ModelState.IsValid)
            {
                if (!objUserDBEntities.Users.Any(m => m.Email == objuserModel.Email))
                {
                    User objUser = new DBModel.User();
                    objUser.CreatedOn = DateTime.Now;
                    objUser.Email = objuserModel.Email;
                    objUser.FirstName = objuserModel.FirstName;
                    objUser.LastName = objuserModel.LastName;
                    objUser.Password = objuserModel.Password;
                    objUser.YoutubeAbone = objuserModel.YoutubeAbone;
                    objUser.Puan = 100;
                    objUserDBEntities.Users.Add(objUser);
                    objUserDBEntities.SaveChanges();
                    objuserModel = new UserModel();
                    objuserModel.SuccessMessage = "User is Succesfully Added";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Email is Already exists!");
                    return View();
                }
            }
            return View();
            
        }
        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View(objLoginModel);
        }
        [HttpPost]

        public ActionResult Login(LoginModel objLoginModel)
        {
            if (ModelState.IsValid)
            {
                var logUser = objUserDBEntities.Users.FirstOrDefault(x => x.Email == objLoginModel.Email && x.Password == objLoginModel.Password);
                if (logUser != null)
                {
                    Session["Email"] = logUser.Email;
                    Session["UserId"] = logUser.UserId;
                    return RedirectToAction("Abone", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Invalid Email and Password");
                    return RedirectToAction("Index", "Home");

                }
            }
            return RedirectToAction("Abone", "Home");
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }
    }
}