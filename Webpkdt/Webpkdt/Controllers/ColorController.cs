using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpkdt.Models.product;

namespace Webpkdt.Controllers
{
    public class ColorController : Controller
    {
        List<color> list_color = new List<color>();
        // GET: Color
        public ActionResult Index()
        {
            return View(color.get_list());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(color cl)
        {
            color.list_color.Add(cl);
            return RedirectToAction("Index");
        }
    }
}