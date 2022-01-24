using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class DashBoardModel
    {
        public List<DashBoardModel> OrderDetail { get; set; }
        public List<DashBoardModel> TakeAwayDetail { get; set; }
        public List<DashBoardModel> DispatchDetail { get; set; }
        public List<DashBoardModel> BillDetail { get; set; }

        #region Bill Notification
        public int Res_Id { get; set; }
        public int Order_id { get; set; }
        public string Table_Name { get; set; }
        public decimal? Total { get; set; }        
        #endregion
        #region Take Away Notification, Dispatch Notification
        public string First_Name { get; set; }
        public string Mobile_No { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        #endregion
    }
}
