using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SmartRestaurant.Model
{
    public class RateModel
    {
        public int Rate_id { get; set; }
        
        public int Supplier_id { get; set; }

        [DisplayName("Supplier Name")]
        public string Supplier_name { get; set; }
        
        public int Mcategory_id { get; set; }

        [DisplayName("Material Category")]
        public string Mcategory_name { get; set; }

        public int Quantity { get; set; }

        [DisplayName("Unit")]
        public string Unit { get; set; }

        [DisplayName("Price")]
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
        //[DisplayName("Supplier Name")]
        //public string Supplier_Id { get; set; }

        //[DisplayName("Material Category")]
        //public string MaterialCategory_Id { get; set; }

        //[DisplayName("Unit")]
        //public string Material_Unit { get; set; }

        //[DisplayName("Price")]
        //public string Material_Price { get; set; }
    }
}
