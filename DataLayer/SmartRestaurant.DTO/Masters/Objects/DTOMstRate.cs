using System;

namespace SmartRestaurant.DTO
{
    public class DTOMstRate : BaseDTO
    {
        public int Rate_id { get; set; }
        public int Supplier_id { get; set; }
        public string Supplier_name { get; set; }
        public int Mcategory_id { get; set; }
        public string Mcategory_name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
        public string ActiveFlg { get; set; }
        public int IntInserted_by { get; set; }
        public string Inserted_date { get; set; }
        public string InseretIP { get; set; }
        public int IntUpdate_by { get; set; }
        public string Updated_date { get; set; }
        public string UpdateIP { get; set; }
        public int IntDelete_by { get; set; }
        public string Deleted_date { get; set; }
        public string DeleteIP { get; set; }
    }
}
