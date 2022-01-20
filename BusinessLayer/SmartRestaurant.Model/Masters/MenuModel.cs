using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartRestaurant.Model
{
    public class MenuModel
    {
        public int Menu_Id { get; set; }
        [DisplayName("Menu Name")]
        [Required(ErrorMessage = "Menu Name Required")]
        public string Menu_Name { get; set; }

        public string Food_Code { get; set; }

        public int Res_id { get; set; }

        public int Is_Active { get; set; }

        [DisplayName("Menu Category")]
        public int Cat_Id { get; set; }

        [DisplayName("Menu Category")]
        public string Cat_Name { get; set; }

        [DisplayName("Price")]
        public int Price { get; set; }

        [DisplayName("Menu Type")]
        public string Menu_Type { get; set; }

        //public List<Type> foodCategoryList { get; set; }

        public string IntInserted_by { get; set; }

        public string Inserted_date { get; set; }

        public string InseretIP { get; set; }

        public string IntUpdate_by { get; set; }

        public string Updated_date { get; set; }

        public string UpdateIP { get; set; }

        public string IntDelete_by { get; set; }

        public string Deleted_date { get; set; }

        public string DeleteIP { get; set; }

        public List<CategoryModel> foodCategoryList { get; set; }
        
        //[DisplayName("Menu Category")]
        //public string Menu_Category { get; set; }

        //[DisplayName("Menu Name")]
        //[Required(ErrorMessage = "Name is required")]
        //public string Menu_Name { get; set; }

        //[DisplayName("Menu Type")]
        //public string Menu_Type { get; set; }

        //[DisplayName("Price")]
        //public string Menu_Price { get; set; }


    }
}
