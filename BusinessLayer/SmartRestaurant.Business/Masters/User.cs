using SmartRestaurant.DAL;
using SmartRestaurant.DTO;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.Business
{
    public class User : BaseBusiness
    {
        public static IMstUser _dalMstUser;

        #region New instance,Select
        /// <summary>
        /// For create new Instance of User Class
        /// </summary>
        /// <returns></returns>
        public static UserModel New()
        {
            try
            {
                return new UserModel();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Failed. " + ex.Message);
            }
        }

        /// <summary>
        /// Get All data from User Master
        /// </summary>
        /// <returns></returns>
        public static List<UserModel> GetAll(int resId)
        {
            try
            {
                _dalMstUser = new DALMstUser();
                return fillUserList(_dalMstUser.GetAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get All data from User Master
        /// </summary>
        /// <returns></returns>
        public static async Task<List<UserModel>> GetAllAsync(int resId)
        {
            try
            {
                _dalMstUser = new DALMstUser();
                List<UserModel> lstUser = await Task.Run(() => { return fillUserList(_dalMstUser.GetAll(resId)); });
                return lstUser;
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get Existing User data by Id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<UserModel> GetExistingAsync(int code,int resId)
        {
            try
            {
                _dalMstUser = new DALMstUser();
                DTOMstUser dtoMstUser = await Task.Run(() => { return _dalMstUser.GetExisting(code, resId); });
                return new UserModel()
                {
                    // Add Column here                    

                    Id = dtoMstUser.Id,
                    User_Name = dtoMstUser.User_Name,
                    UserType_Id = dtoMstUser.UserType_Id,
                    Employee_Id = dtoMstUser.Employee_Id,
                    Password = dtoMstUser.Password,
                    Res_Id = 1
                };
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<UserModel> fillUserList(List<DTOMstUser> _objDtoMstUser)
        {
            var list = from dtoMstUser in _objDtoMstUser
                       select new UserModel()
                       {
                           // Add your Column here
                           Id = dtoMstUser.Id,
                           User_Name = dtoMstUser.User_Name,
                           UserType_Id = dtoMstUser.UserType_Id,
                           Employee_Id = dtoMstUser.Employee_Id,
                           Password = dtoMstUser.Password,
                           Res_Id = dtoMstUser.Res_Id

                       };
            return list.AsEnumerable<UserModel>().ToList();
        }
        #endregion

        #region Insert,Update,Delete
        /// <summary>
        /// Insert data in User Master
        /// </summary>
        /// <param name="_objUser"></param>
        /// <returns></returns>
        public static async Task<int> Create(UserModel _objUser)
        {
            try
            {
                int result = 0;
                _dalMstUser = new DALMstUser();
                DTOMstUser _objDtoUser = new DTOMstUser()
                {
                    // Add your Column here
                    Id = _objUser.Id,
                    User_Name = _objUser.User_Name,
                    UserType_Id = _objUser.UserType_Id,
                    Employee_Id = _objUser.Employee_Id,
                    Password = _objUser.Password,
                    Res_Id = _objUser.Res_Id
                };
                result = await Task.Run(() => { return _dalMstUser.Create(_objDtoUser); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Insert");
            }
        }

        /// <summary>
        /// Update User Master
        /// </summary>
        /// <param name="_objUser"></param>
        /// <returns></returns>
        public static async Task<int> Edit(UserModel _objUser)
        {
            try
            {
                int result = 0;
                DTOMstUser _objDtoUser = new DTOMstUser()
                {
                    // Add your Column here
                    Id = _objUser.Id,
                    User_Name = _objUser.User_Name,
                    UserType_Id = _objUser.UserType_Id,
                    Employee_Id = _objUser.Employee_Id,
                    Password = _objUser.Password,
                    Res_Id = _objUser.Res_Id
                };
                result = await Task.Run(() => { return _dalMstUser.Edit(_objDtoUser); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Update");
            }
        }

        /// <summary>
        /// Delete User Master
        /// </summary>
        /// <param name="_objUser"></param>
        /// <returns></returns>
        public static async Task<int> Delete(UserModel _objUser)
        {
            try
            {
                int result = 0;
                DTOMstUser _objDtoUser = new DTOMstUser()
                {
                    Id = _objUser.Id,
                    User_Name = _objUser.User_Name,
                    UserType_Id = _objUser.UserType_Id,
                    Employee_Id = _objUser.Employee_Id,
                    Password = _objUser.Password,
                    Res_Id = _objUser.Res_Id
                };
                result = await Task.Run(() => { return _dalMstUser.Delete(_objDtoUser); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Delete");
            }
        }
        #endregion
    }
}
