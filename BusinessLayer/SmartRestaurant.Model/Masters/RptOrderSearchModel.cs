using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class RptOrderSearchModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string FromDate {get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string ToDate { get; set; }

        public string Status { get; set; }
        public string MenuName { get; set; }
        public int EmployeeId { get; set; }

        public List<RptOrderModel> LstOrderDetials { get; set; }
        public List<RptAttendenceModel> LstAttendences { get; set; }
    }
}

