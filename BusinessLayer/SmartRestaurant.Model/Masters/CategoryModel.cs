using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartRestaurant.Culture;

namespace SmartRestaurant.Model
{
    public class CategoryModel
    {
        public int Cat_Id { get; set; }

        [Display(Name = "CAT_NAME", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "CAT_NAME_REQUIRED")]
        public string Cat_Name { get; set; }

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
        public string Url_Category { get; set; }
    }
}
