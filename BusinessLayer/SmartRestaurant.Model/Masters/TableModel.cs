using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SmartRestaurant.Culture;

namespace SmartRestaurant.Model
{
    public class TableModel
    {
        public int Table_Id { get; set; }

        [Display(Name = "TableName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "TableNameRequired")]
        public string Table_Name { get; set; }

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
