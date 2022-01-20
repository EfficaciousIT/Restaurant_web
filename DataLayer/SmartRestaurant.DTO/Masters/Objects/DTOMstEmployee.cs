using System;

namespace SmartRestaurant.DTO
{
    public class DTOMstEmployee : BaseDTO
    {
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string fullName { get; set; }
        public string Mobile_No { get; set; }
        public string Email_Id { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string Address_3 { get; set; }
        public string Gender { get; set; }
        public int Res_Id { get; set; }
        public string Imei_No { get; set; }
        public string vchProfile { get; set; }
        public string vchFcmToken { get; set; }
        public string CreatedDate { get; set; }
        public string ActiveFlg { get; set; }
        public string IntInserted_by { get; set; }
        public string Inserted_date { get; set; }
        public string InseretIP { get; set; }
        public string IntUpdate_by { get; set; }
        public string Updated_date { get; set; }
        public string UpdateIP { get; set; }
        public string IntDelete_by { get; set; }
        public string Deleted_date { get; set; }
        public string DeleteIP { get; set; }
    }
}
