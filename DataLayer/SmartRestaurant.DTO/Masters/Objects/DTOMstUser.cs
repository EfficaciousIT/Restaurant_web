using System;

namespace SmartRestaurant.DTO
{
    public class DTOMstUser : BaseDTO
    {
        public int Id { get; set; }
        public int Res_Id { get; set; }
        public int Employee_Id { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public int UserType_Id { get; set; }
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
