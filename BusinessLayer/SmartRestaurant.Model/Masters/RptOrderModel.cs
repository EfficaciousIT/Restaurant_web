﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class RptOrderModel
    {
        public int Order_id { get; set; }
        public decimal grandTotal { get; set; }
        public string Table_Name { get; set; }
        public decimal Total { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string Menu_Name { get; set; }
        public string status { get; set; }
        public int Res_Id { get; set; }
        public string Date { get; set; }
    }
}
