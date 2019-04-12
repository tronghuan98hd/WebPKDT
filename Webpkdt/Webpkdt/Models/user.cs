using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webpkdt.Models.user
{
    public class user
    {
        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public static List<user> list_user = new List<user>()
        {
            new user() {id = 1, name = "Nguyen Van A", adress="Ha Noi", phone="0123", email="abc@yahoo.com"},
            new user() {id = 2, name = "Nguyen Van B", adress="Hai Duong", phone="0389", email="xyz@yahoo.com"},
            new user() {id = 3, name = "Nguyen Van C", adress="Thai Binh", phone="0357", email="mnp@gmail.com"},
            new user() {id = 4, name = "Nguyen Van D", adress="Quang Ninh", phone="0983", email="example@icloud.com"},
            new user() {id = 5, name = "Nguyen Van E", adress="Hai Phong", phone="0977", email="cbc@gmail.com"},
        };
        public static List<user> get_list()
        {
            return list_user;
        }
    }
}