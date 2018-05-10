using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAndRewards.BL.Logic;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.Web.Controllers
{
    public class RewardsController : Controller
    {
        // GET: Rewards
        ILogic logik = new Logic();
        public ActionResult Index()
        {
            return View("Index",logik.GetRewardViewModels());
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult SubmitReward(Reward reward)
        {
            logik.AddReward(reward);
            return RedirectToAction("Index","Users");
        }
    }
}