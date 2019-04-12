using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpkdt.Models.user;

namespace Webpkdt.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(user.get_list());
        }
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(loign user)
        {
            if ("admin".Equals(user.account) & "123".Equals(user.password))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        //Tao moi user
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(user us)
        {
            user.list_user.Add(us);
            return RedirectToAction("Index");
        }

        //Sua thong tin user
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var us = user.list_user.SingleOrDefault(x => x.id == id);
            return View(us);
        }
        [HttpPost]
        public ActionResult Edit(user us)
        {
            var findus = user.list_user.SingleOrDefault(x => x.id == us.id);
            if(findus != null)
            {
                findus.name = us.name;
                findus.adress = us.adress;
                findus.phone = us.phone;
                findus.email = us.email;
            }
            return RedirectToAction("Index");
        }

        //Xoa thong tin user
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var us = user.list_user.SingleOrDefault(x => x.id == id);
            return View(us);
        }
        [HttpPost]
        public ActionResult Delete(user us)
        {
            var findus = user.list_user.SingleOrDefault(x => x.id == us.id);
            user.list_user.Remove(findus);
            return RedirectToAction("Index");
        }
    }
}