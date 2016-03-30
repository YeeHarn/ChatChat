using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatChat.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Chat(int id)
        {
            ViewBag.MemberId = id;
            return View();
        }
    }
}