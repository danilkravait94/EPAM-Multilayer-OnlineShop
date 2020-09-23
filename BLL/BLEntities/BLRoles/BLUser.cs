﻿using DAL.DataBase;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLEntities.BLRoles
{
    public class BLUser 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Pasword { get; set; }
        public long NumberofCard { get; set; }
        public decimal Money { get; set; }
        public List<BLOrder> Orders { get; set; } = new List<BLOrder>();
        public List<BLProduct> Basket { get; set; } = new List<BLProduct>();
    }
}
