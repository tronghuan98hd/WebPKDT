using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpkdt.Models.product;

namespace Webpkdt.Controllers
{
    public class ProductController : Controller
    {
        List<product> list_products = new List<product>();

        // GET: Product
        // tao list cac san pham
        public ActionResult Index()
        {
            return View(product.get_list());
        }

        //Tao moi mot san pham
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(product Pr)
        {
            product.list_product.Add(Pr);
            return RedirectToAction("Index");
        }

        //Chinh sua thong tin san pham
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Pr = product.list_product.SingleOrDefault(x => x.id == id);
            return View(Pr);
        }
        [HttpPost]
        public ActionResult Edit(product Pr)
        {
            var findPr = product.list_product.SingleOrDefault(x => x.id == Pr.id);
            if (findPr != null)
            {
                findPr.id = Pr.id;
                findPr.name = Pr.name;
                findPr.price = Pr.price;
            }
            return RedirectToAction("Index");
        }

        //xoa san pham
        public ActionResult Delete(int id)
        {
            var Pr = product.list_product.SingleOrDefault(x => x.id == id);
            return View(Pr);
        }
        [HttpPost]
        public ActionResult Delete(product Pr)
        {
            var findPr = product.list_product.SingleOrDefault(x => x.id == Pr.id);
            product.list_product.Remove(findPr);
            return RedirectToAction("Index");
        }
    }
}