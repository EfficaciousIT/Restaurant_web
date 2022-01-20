using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartRestaurant.Culture;
namespace SmartRestaurant.Model
{
    public class RestaurantModel:BaseModel
    {
        public string ResId { get; set; }

        [Display(Name = "RESTAURANT_NAME", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "RESTAURANT_NAME_REQUIRED")]
        public string Res_Name { get; set; }

        [Display(Name = "RESTAURANT_ADDRESS1", ResourceType = typeof(Resource))]
        public string RESTAURANT_ADDRESS1 { get; set; }

        [Display(Name = "RESTAURANT_ADDRESS2", ResourceType = typeof(Resource))]
        public string RESTAURANT_ADDRESS2 { get; set; }

        [Display(Name = "RESTAURANT_ADDRESS3", ResourceType = typeof(Resource))]
        public string RESTAURANT_ADDRESS3 { get; set; }

        [Display(Name = "RESTAURANT_AREA", ResourceType = typeof(Resource))]
        public string Res_Area { get; set; }

        [Display(Name = "RESTAURANT_TYPE", ResourceType = typeof(Resource))]
        public string Res_Type { get; set; }

        public string Res_Type_Name { get; set; }        

        [Display(Name = "EMAIL_ID", ResourceType = typeof(Resource))]
        [EmailAddress(ErrorMessage ="Please fill proper email id")]
        public string Res_Email { get; set; }

        [Display(Name = "PHONE_NUMBER", ResourceType = typeof(Resource))]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Res_Phone { get; set; }

        [Display(Name = "RESTAURANT_GSTIN", ResourceType = typeof(Resource))]
        [RegularExpression("^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$", ErrorMessage = "Invalid GST Number.")]
        public string Res_GSTIN { get; set; }

        //---------for login functionality------------------------
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        [NotMapped] // Does not effect with your database        
        [Compare("Password",ErrorMessage = "Password do not match.") ]
        public string ConfirmPassword { get; set; }

        public string UserName { get; set; }
        public int UserType { get; set; }
    }
}
