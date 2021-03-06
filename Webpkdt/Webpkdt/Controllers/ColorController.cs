﻿using System;
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
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var cl = color.list_color.SingleOrDefault(x => x.id == id);
            return View(cl);
        }
        [HttpPost]
        public ActionResult Edit(color cl)
        {
            var findcl = color.list_color.SingleOrDefault(x => x.id == cl.id);
            if (findcl != null)
            {
                findcl.id = cl.id;
                findcl.name = cl.name;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var cl = color.list_color.SingleOrDefault(x => x.id == id);
            return View(cl);
        }
        [HttpPost]
        public ActionResult Delete(color cl)
        {
            var findcl = color.list_color.SingleOrDefault(x => x.id == cl.id);
            color.list_color.Remove(findcl);
            return RedirectToAction("Index");
        }
    }
}