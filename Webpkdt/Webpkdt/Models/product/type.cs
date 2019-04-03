using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webpkdt.Models.product
{
    public class type
    {
        public int id { get; set; }
        public string name { get; set; }
        public static List<type> list_type = new List<type>()
        {
            new type() {id = 1, name = "Sac"},
            new type() {id = 2, name = "Op lung"},
            new type() {id = 3, name = "Cap"},
            new type() {id = 4, name = "Gay tu suong"},
            new type() {id = 4, name = "tai nghe"},
        };
        public static List<type> get_list()
        {
            return list_type;
        }
    }
}