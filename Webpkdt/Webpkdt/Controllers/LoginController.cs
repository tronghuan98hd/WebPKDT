using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpkdt.Models.user;
using Webpkdt.Models.product;

namespace Webpkdt.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(loign user)
        {
            string us = Request.Form["us"];
            string mk = Request.Form["mk"];
            if ("admin".Equals(us) & "123".Equals(mk))
            {
                return View("~/Views/Product/Index.cshtml");
            }
            return View();
        }
    }
}