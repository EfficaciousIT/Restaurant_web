using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartRestaurant.Model
{
    public class UserTypeModel
    {
        public int User_Id { get; set; }

        [DisplayName("User Type")]
        [Required(ErrorMessage = "User Type is required")]
        public string User_Name { get; set; }

        public int Res_Id { get; set; }

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
