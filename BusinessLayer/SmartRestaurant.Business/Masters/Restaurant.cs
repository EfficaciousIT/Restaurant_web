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
    public class Restaurant:BaseBusiness
    {
        public static IMstRestaurant _dalMstRestaurant;
        
        #region New instance,Select
        /// <summary>
        /// For create new Instance of Restaurant Class
        /// </summary>
        /// <returns></returns>
        public static RestaurantModel New()
        {
            try
            {
                return new RestaurantModel();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Failed. " + ex.Message);
            }
        }

        /// <summary>
        /// Get All data from Restaurant Master
        /// </summary>
        /// <returns></returns>
        public static List<RestaurantModel> GetAll(int resId)
        {
            try
            {
                _dalMstRestaurant = new DALMstRestaurant();
                return fillRestaurantList(_dalMstRestaurant.GetAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get All data from Restaurant Master
        /// </summary>
        /// <returns></returns>
        public static async Task<List<RestaurantModel>> GetAllAsync(int resId)
        {
            try
            {
                _dalMstRestaurant = new DALMstRestaurant();
                List<RestaurantModel> lstRestaurant = await Task.Run(() => { return fillRestaurantList(_dalMstRestaurant.GetAll(resId)); });
                return lstRestaurant;
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get Existing Restaurant data by Id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<RestaurantModel> GetExistingAsync(int code,int resId)
        {
            try
            {
                _dalMstRestaurant = new DALMstRestaurant();
                DTOMstRestaurant dtoMstRestaurant = await Task.Run(() => { return _dalMstRestaurant.GetExisting(code, resId); });
                return new RestaurantModel()
                {
                    ResId = dtoMstRestaurant.ResId,
                    Res_Name = dtoMstRestaurant.Res_Name,
                    Res_Area = dtoMstRestaurant.Res_Area,
                    Res_Type = dtoMstRestaurant.Res_Type,
                    Res_Email = dtoMstRestaurant.Res_Email,
                    Res_Phone = dtoMstRestaurant.Res_Phone,
                    Res_GSTIN = dtoMstRestaurant.Res_GSTIN,
                };
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<RestaurantModel> fillRestaurantList(List<DTOMstRestaurant> _objDtoMstRestaurant)
        {
            var list = from dtoMstRestaurant in _objDtoMstRestaurant
                       select new RestaurantModel()
                       {
                            ResId = dtoMstRestaurant.ResId,
                            Res_Name = dtoMstRestaurant.Res_Name,
                            Res_Area = dtoMstRestaurant.Res_Area,
                            Res_Type = dtoMstRestaurant.Res_Type,
                            Res_Email = dtoMstRestaurant.Res_Email,
                            Res_Phone = dtoMstRestaurant.Res_Phone,
                            Res_GSTIN = dtoMstRestaurant.Res_GSTIN,

                       };
            return list.AsEnumerable<RestaurantModel>().ToList();
        }
        #endregion

        #region Insert,Update,Delete
        /// <summary>
        /// Insert data in Restaurant Master
        /// </summary>
        /// <param name="_objRestaurant"></param>
        /// <returns></returns>
        public static async Task<int> Create(RestaurantModel _objRestaurant)
        {
            try
            {
                int result = 0;
                string intStatusCode = "1";
                _dalMstRestaurant = new DALMstRestaurant();
                DTOMstRestaurant _objDtoRestaurant = new DTOMstRestaurant()
                {
                    ResId       = _objRestaurant.ResId,
                    Res_Name    = _objRestaurant.Res_Name,
                    Res_Area    = _objRestaurant.Res_Area,
                    Res_Type    = _objRestaurant.Res_Type,
                    Res_Email   = _objRestaurant.Res_Email,
                    Res_Phone   = _objRestaurant.Res_Phone,
                    Res_GSTIN   = _objRestaurant.Res_GSTIN,
                };
                result = await Task.Run(() => { return _dalMstRestaurant.Create(_objDtoRestaurant); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Insert");
            }
        }

        /// <summary>
        /// Update Restaurant Master
        /// </summary>
        /// <param name="_objRestaurant"></param>
        /// <returns></returns>
        public static async Task<int> Edit(RestaurantModel _objRestaurant)
        {
            try
            {
                int result = 0;
                DTOMstRestaurant _objDtoRestaurant = new DTOMstRestaurant()
                {
                    ResId = _objRestaurant.ResId,
                    Res_Name = _objRestaurant.Res_Name,
                    Res_Area = _objRestaurant.Res_Area,
                    Res_Type = _objRestaurant.Res_Type,
                    Res_Email = _objRestaurant.Res_Email,
                    Res_Phone = _objRestaurant.Res_Phone,
                    Res_GSTIN = _objRestaurant.Res_GSTIN,
                };
                result = await Task.Run(() => { return _dalMstRestaurant.Edit(_objDtoRestaurant); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Update");
            }
        }

        /// <summary>
        /// Delete Restaurant Master
        /// </summary>
        /// <param name="_objRestaurant"></param>
        /// <returns></returns>
        public static async Task<int> Delete(RestaurantModel _objRestaurant)
        {
            try
            {
                int result = 0;
                DTOMstRestaurant _objDtoRestaurant = new DTOMstRestaurant()
                {
                    ResId = _objRestaurant.ResId,
                    Res_Name = _objRestaurant.Res_Name,
                    Res_Area = _objRestaurant.Res_Area,
                    Res_Type = _objRestaurant.Res_Type,
                    Res_Email = _objRestaurant.Res_Email,
                    Res_Phone = _objRestaurant.Res_Phone,
                    Res_GSTIN = _objRestaurant.Res_GSTIN,
                };
                result = await Task.Run(() => { return _dalMstRestaurant.Delete(_objDtoRestaurant); });
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
