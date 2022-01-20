using System;

namespace SmartRestaurant.DTO
{
    public class DTOMstMenu : BaseDTO
    {
        public int Menu_Id { get; set; }
        public string Menu_Name { get; set; }
        public string Food_Code { get; set; }
        public int Res_id { get; set; }
        public int Is_Active { get; set; }
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public int Price { get; set; }
        public string Menu_Type { get; set; }
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
