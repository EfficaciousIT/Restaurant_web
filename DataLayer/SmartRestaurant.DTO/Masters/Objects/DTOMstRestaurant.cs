using System;

namespace SmartRestaurant.DTO
{
    public class DTOMstRestaurant: BaseDTO
    {
        
        public string ResId { get; set; }
        public string Res_Name { get; set; }
        public string Res_Area { get; set; }
        public string Res_Type { get; set; }
        public string Res_Email { get; set; }
        public string Res_Phone { get; set; }
        public string Res_GSTIN { get; set; }

        //public int RESTAURANT_CODE { get; set; }
        //public string RESTAURANT_NAME { get; set; }
        //public string RESTAURANT_ADDRESS1 { get; set; }
        //public string RESTAURANT_ADDRESS2 { get; set; }
        //public string RESTAURANT_ADDRESS3 { get; set; }
        //public string RESTAURANT_AREA { get; set; }
        //public string PHONE_NUMBER { get; set; }
        //public string MOBILE_NUMBER { get; set; }
        //public string EMAIL_ID { get; set; }
        //public int RESTAURANT_TYPE { get; set; }
        //public string RESTAURANT_GSTIN { get; set; }
    }
}
