using System;

namespace SmartRestaurant.Business
{
    public class BaseBusiness
    {
        public string IntInserted_by { get; set; }
        public DateTime? Inserted_date { get; set; }
        public string InseretIP { get; set; }
        public string IntUpdate_by { get; set; }
        public DateTime? Updated_date { get; set; }
        public string UpdateIP { get; set; }
        public string IntDelete_by { get; set; }
        public DateTime? Deleted_date { get; set; }
        public string DeleteIP { get; set; }
        public string ActiveFlg { get; set; }
    }  
}
