using DAL.Entities;
using DAL.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataBase
{
    public class Context
    {
        public List<Product> Products { get; set; } = new List<Product>();
       // public List<Order> Orders { get; set; } = new List<Order>();
        public List<User> Users { get; set; } = new List<User>();
       // public List<Product> Basket { get; set; } = new List<Product>();
        static Context()
        {
        }
        public Context(List<Product> products,List<User> users)
        {
            Products = products;
            Users = users;
        }
        

    }
}
