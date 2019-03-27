using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webpkdt.Models.product
{
    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public static List<product> list_product = new List<product>()
        {
            new product() {id = 1, name = "Tai nghe khong day", price = 200000},
            new product() {id = 2, name = "Op lung", price = 300000},
            new product() {id = 3, name = "Gay chup anh tu suong", price = 400000},
            new product() {id = 4, name = "Cap sac iphone", price = 500000},
            new product() {id = 4, name = "Sac du phong", price = 100000},
        };
        public static List<product> get_list()
        {
            return list_product;
        }
        public void Add(product pr)
        {
            list_product.Add(pr);
        }
    }
}