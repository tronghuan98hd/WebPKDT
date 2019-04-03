using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpkdt.Models.product;

namespace Webpkdt.Controllers
{
    public class TypeController : Controller
    {
        List<type> list_type = new List<type>();
        // GET: Type
        public ActionResult Index()
        {
            return View(type.get_list());
        }

        //Them loai hang moi
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(type T)
        {
            type.list_type.Add(T);
            return RedirectToAction("Index");
        }

        //Sua loai mat hang
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var cl = color.list_color.SingleOrDefault(x => x.id == id);
            return View(cl);
        }

        [HttpPost]
        public ActionResult Edit(type T)
        {
            var findt = type.list_type.SingleOrDefault(x => x.id == T.id);
            if (findt != null)
            {
                findt.id = T.id;
                findt.name = T.name;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var T = type.list_type.SingleOrDefault(x => x.id == id);
            return View(T);
        }
        [HttpPost]
        public ActionResult Delete(type T)
        {
            var findT = type.list_type.SingleOrDefault(x => x.id == T.id);
            type.list_type.Remove(findT);
            return RedirectToAction("Index");
        }
    }
}