﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class RptAttendenceModel
    {
        public int Employee_Id { get; set; }
        public int Res_Id { get; set; }
        public string Intime { get; set; }
        public string Outtime { get; set; }
        public string Date { get; set; }
        public string WorkingHRS { get; set; }
        public string Employee_Name { get; set; }
    }
}
