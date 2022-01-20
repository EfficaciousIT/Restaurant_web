using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class FoodCategoryModel
    {
        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category Name is required")]
        public string Name { get; set; }
    }
}
