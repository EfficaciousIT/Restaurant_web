using System;

namespace SmartRestaurant.DTO
{
    public class DTORptOrder : BaseDTO
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
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
    }
}
