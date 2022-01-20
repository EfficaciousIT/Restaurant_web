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
    public class UserType : BaseBusiness
    {
        public static IMstUserType _dalMstUserType;

        #region New instance,Select
        /// <summary>
        /// For create new Instance of UserType Class
        /// </summary>
        /// <returns></returns>
        public static UserTypeModel New()
        {
            try
            {
                return new UserTypeModel();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Failed. " + ex.Message);
            }
        }

        /// <summary>
        /// Get All data from UserType Master
        /// </summary>
        /// <returns></returns>
        public static List<UserTypeModel> GetAll(int resId)
        {
            try
            {
                _dalMstUserType = new DALMstUserType();
                return fillUserTypeList(_dalMstUserType.GetAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get All data from UserType Master
        /// </summary>
        /// <returns></returns>
        public static async Task<List<UserTypeModel>> GetAllAsync(int resId)
        {
            try
            {
                _dalMstUserType = new DALMstUserType();
                List<UserTypeModel> lstUserType = await Task.Run(() => { return fillUserTypeList(_dalMstUserType.GetAll(resId)); });
                return lstUserType;
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get Existing UserType data by User_Id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<UserTypeModel> GetExistingAsync(int code,int resId)
        {
            try
            {
                _dalMstUserType = new DALMstUserType();
                DTOMstUserType dtoMstUserType = await Task.Run(() => { return _dalMstUserType.GetExisting(code, resId); });
                return new UserTypeModel()
                {
                    // Add Column here                    
                    User_Id = dtoMstUserType.User_Id,
                    User_Name = dtoMstUserType.User_Name,
                    Res_Id = 1,
                };
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<UserTypeModel> fillUserTypeList(List<DTOMstUserType> _objDtoMstUserType)
        {
            var list = from dtoMstUserType in _objDtoMstUserType
                       select new UserTypeModel()
                       {
                           // Add your Column here
                           User_Id = dtoMstUserType.User_Id,
                           User_Name = dtoMstUserType.User_Name,
                           Res_Id = dtoMstUserType.Res_Id,

                       };
            return list.AsEnumerable<UserTypeModel>().ToList();
        }
        #endregion

        #region Insert,Update,Delete
        /// <summary>
        /// Insert data in UserType Master
        /// </summary>
        /// <param name="_objUserType"></param>
        /// <returns></returns>
        public static async Task<int> Create(UserTypeModel _objUserType)
        {
            try
            {
                int result = 0;
                string intStatusCode = "1";
                _dalMstUserType = new DALMstUserType();

                DTOMstUserType _objDtoUserType = new DTOMstUserType()
                {
                    // Add your Column here
                    User_Id = _objUserType.User_Id,
                    User_Name = _objUserType.User_Name,
                    Res_Id = _objUserType.Res_Id
                };
                result = await Task.Run(() => { return _dalMstUserType.Create(_objDtoUserType); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Insert");
            }
        }

        /// <summary>
        /// Update UserType Master
        /// </summary>
        /// <param name="_objUserType"></param>
        /// <returns></returns>
        public static async Task<int> Edit(UserTypeModel _objUserType)
        {
            try
            {
                int result = 0;
                DTOMstUserType _objDtoUserType = new DTOMstUserType()
                {
                    // Add your Column here
                    User_Id = _objUserType.User_Id,
                    User_Name = _objUserType.User_Name,
                    Res_Id = _objUserType.Res_Id
                };
                result = await Task.Run(() => { return _dalMstUserType.Edit(_objDtoUserType); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Update");
            }
        }

        /// <summary>
        /// Delete UserType Master
        /// </summary>
        /// <param name="_objUserType"></param>
        /// <returns></returns>
        public static async Task<int> Delete(UserTypeModel _objUserType)
        {
            try
            {
                int result = 0;
                DTOMstUserType _objDtoUserType = new DTOMstUserType()
                {
                    User_Id = _objUserType.User_Id,
                    User_Name = _objUserType.User_Name,
                    Res_Id = _objUserType.Res_Id
                };
                result = await Task.Run(() => { return _dalMstUserType.Delete(_objDtoUserType); });
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
