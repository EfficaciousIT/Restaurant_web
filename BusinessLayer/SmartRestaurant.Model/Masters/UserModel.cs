using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartRestaurant.Model
{
    public class UserModel
    {
        public int Id { get; set; }

        public int Res_Id { get; set; }

        [DisplayName("Employee Name")]
        public int Employee_Id { get; set; }

        public List<EmployeeModel> LstEmployee { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name Required")]
        public string User_Name { get; set; }

        [DisplayName("Password")]        
        public string Password { get; set; }

        [DisplayName("User Type")]
        public int UserType_Id { get; set; }

        public List<UserTypeModel> LstUserType { get; set; }

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
        
        //[DisplayName("User Type")]
        //public string UserType_Id { get; set; }

        //[DisplayName("Employee Name")]
        //public string Employee_Id { get; set; }

        //[DisplayName("User Name")]
        //[Required(ErrorMessage = "User Name is required")]
        //public string User_Name { get; set; }

        //[DisplayName("Password")]        
        //public string User_Password { get; set; }
    }
}
