using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model
{
    public class EmployeeModel
    {

        public int Employee_Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        public string First_Name { get; set; }
        [Display(Name = "Middle Name")]        
        public string Middle_Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string Last_Name { get; set; }
        [Display(Name = "Employee Name")]
        public string fullName { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number Required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile_No { get; set; }

        [Display(Name = "Email Id")]
        [EmailAddress(ErrorMessage = "Please fill proper email id")]
        public string Email_Id { get; set; }
        [Display(Name = "Address 1")]
        public string Address_1 { get; set; }
        [Display(Name = "Address 2")]
        public string Address_2 { get; set; }
        [Display(Name = "Address 3")]
        public string Address_3 { get; set; }
        [Display(Name = "Gender")]
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
