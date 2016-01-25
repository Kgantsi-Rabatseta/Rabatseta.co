using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Builders.ObjectBuilders;
using Rabatseta.co.Models;

namespace Rabatseta.co.Controllers.Users
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult ListUsers()
        {
            ViewBag.Title = "All Users";
            UserIdentityViewModel userData = GetAllUserData();
            userData.UserData = userData.UserData.OrderBy(u => u.YearOfBirth)
               .ToList();
            ViewBag.UserData = userData;
            return View();
        }

        private UserIdentityViewModel GetAllUserData()
        {
            //to mimic the data.Get-All-Users
            return new UserIdentityViewModel(SysUserBuilder.BuildSysUsers(50));
        }

        public ActionResult CreateSysUser()
        {
            return View();
        }
    }
}