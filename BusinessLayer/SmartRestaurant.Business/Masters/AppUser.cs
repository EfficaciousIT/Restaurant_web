using SmartRestaurant.DAL;
using SmartRestaurant.DTO;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SmartRestaurant.Business
{
    public class AppUser
    {
        public static IMstUser _dalMstUser;
        public static IMstRestaurant _dalMstRestaurant;
        public bool Succeeded = false;
        public static UserModel UserDtl { get; set; }
        public AppUser(RestaurantModel restaurantModel)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    _dalMstRestaurant = new DALMstRestaurant();
                    _dalMstUser = new DALMstUser();
                    int resId;
                    DTOMstRestaurant dTOMstRestaurant = new DTOMstRestaurant()
                    {
                        Res_Name = restaurantModel.Res_Name,
                        Res_Type = restaurantModel.Res_Type,
                        Res_Email = restaurantModel.Res_Email,
                        Res_Area = restaurantModel.Res_Area,
                        Res_Phone = restaurantModel.Res_Phone,
                    };
                    resId = _dalMstRestaurant.RegisterNewRestaurant(dTOMstRestaurant);

                    DTOMstUser _objDtoUser = new DTOMstUser()
                    {
                        // Add your Column here                    
                        User_Name = restaurantModel.UserName,
                        Employee_Id = 1,
                        UserType_Id = 1,
                        Password = restaurantModel.Password,
                        Res_Id = resId
                    };
                    int result = _dalMstUser.Create(_objDtoUser);  //await Task.Run(() => {  });
                    if (result > 0)
                    {
                        transaction.Complete();
                        Succeeded = true;
                    }
                    else
                    {
                        transaction.Dispose();
                    }
                    
                }
                catch
                {
                    transaction.Dispose();
                    throw new Exception("Failed To Insert");
                }
            }
        }

        public static bool CheckLogin(UserModel userModel)
        {
            _dalMstUser = new DALMstUser();
            DTOMstUser dTOMstUser = new DTOMstUser
            {
                User_Name = userModel.User_Name,
                Password = userModel.Password
            };
            var list =_dalMstUser.CheckLogin(dTOMstUser);
            if (list.Res_Id > 0)
            {
                UserDtl = new UserModel
                {
                    Res_Id = list.Res_Id,
                    UserType_Id = list.UserType_Id,
                    Employee_Id = list.Employee_Id,
                    User_Name = list.User_Name,
                    //Password = list.Password

                };
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
