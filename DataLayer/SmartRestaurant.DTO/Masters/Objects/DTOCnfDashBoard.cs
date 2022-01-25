using System;

namespace SmartRestaurant.DTO
{
    public class DTOCnfDashBoard : BaseDTO
    {
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

