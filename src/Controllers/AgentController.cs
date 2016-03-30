using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatChat.Controllers
{
    public class AgentController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        // GET: Agent
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}