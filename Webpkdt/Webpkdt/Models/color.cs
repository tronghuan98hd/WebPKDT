using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webpkdt.Models.product
{
    public class color
    {
        public int id { get; set; }
        public string name { get; set; }
        public static List<color> list_color = new List<color>()
        {
            new color() {id = 1, name = "do"},
            new color() {id = 2, name = "xanh"},
            new color() {id = 3, name = "vang"},
            new color() {id = 4, name = "den"},
            new color() {id = 4, name = "trang"},
        };
        public static List<color> get_list()
        {
            return list_color;
        }
    }
}