using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAndRewards.BL.Logic;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.Web.Controllers
{
    public class UsersController : Controller
    {
        ILogic logic = new Logic();

        // GET: Users
        public ActionResult Index()
        {
            return View(logic.GetUsersViewModel());
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult AddUser(User user)
        {
            logic.AddUser(user);
            return RedirectToAction("Index","Rewards");
        }
    }
}