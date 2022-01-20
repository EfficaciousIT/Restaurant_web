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
    public class Category : BaseBusiness
    {
        public static IMstCategory _dalMstCategory;

        #region New instance,Select
        /// <summary>
        /// For create new Instance of Category Class
        /// </summary>
        /// <returns></returns>
        public static CategoryModel New()
        {
            try
            {
                return new CategoryModel();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Failed. " + ex.Message);
            }
        }

        /// <summary>
        /// Get All data from Category Master
        /// </summary>
        /// <returns></returns>
        public static List<CategoryModel> GetAll(int resId)
        {
            try
            {   
                _dalMstCategory = new DALMstCategory();
                return fillCategoryList(_dalMstCategory.GetAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get All data from Category Master
        /// </summary>
        /// <returns></returns>
        public static async Task<List<CategoryModel>> GetAllAsync(int resId)
        {
            try
            {
                _dalMstCategory = new DALMstCategory();
                List<CategoryModel> lstCategory = await Task.Run(() => { return fillCategoryList(_dalMstCategory.GetAll(resId)); });
                return lstCategory;
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get Existing Category data by Cat_Id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<CategoryModel> GetExistingAsync(int code,int resId)
        {
            try
            {
                _dalMstCategory = new DALMstCategory();
                DTOMstCategory dtoMstCategory = await Task.Run(() => { return _dalMstCategory.GetExisting(code, resId); });
                return new CategoryModel()
                {
                    // Add Column here                    
                    Cat_Id = dtoMstCategory.Cat_Id,
                    Cat_Name = dtoMstCategory.Cat_Name,
                    Res_Id = 1,
                };
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<CategoryModel> fillCategoryList(List<DTOMstCategory> _objDtoMstCategory)
        {
            var list = from dtoMstCategory in _objDtoMstCategory
                       select new CategoryModel()
                       {
                           // Add your Column here
                           Cat_Id = dtoMstCategory.Cat_Id,
                           Cat_Name = dtoMstCategory.Cat_Name,
                           Res_Id = dtoMstCategory.Res_Id

                       };
            return list.AsEnumerable<CategoryModel>().ToList();
        }
        #endregion

        #region Insert,Update,Delete
        /// <summary>
        /// Insert data in Category Master
        /// </summary>
        /// <param name="_objCategory"></param>
        /// <returns></returns>
        public static async Task<int> Create(CategoryModel _objCategory)
        {
            try
            {
                int result = 0;
                string intStatusCode = "1";
                _dalMstCategory = new DALMstCategory();

                DTOMstCategory _objDtoCategory = new DTOMstCategory()
                {
                    // Add your Column here
                    Cat_Name = _objCategory.Cat_Name,
                    Res_Id = _objCategory.Res_Id,
                };
                result = await Task.Run(() => { return _dalMstCategory.Create(_objDtoCategory); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Insert");
            }
        }

        /// <summary>
        /// Update Category Master
        /// </summary>
        /// <param name="_objCategory"></param>
        /// <returns></returns>
        public static async Task<int> Edit(CategoryModel _objCategory)
        {
            try
            {
                int result = 0;
                DTOMstCategory _objDtoCategory = new DTOMstCategory()
                {
                    // Add your Column here
                    Cat_Id = _objCategory.Cat_Id,
                    Cat_Name = _objCategory.Cat_Name,
                    Res_Id = _objCategory.Res_Id,
                };
                result = await Task.Run(() => { return _dalMstCategory.Edit(_objDtoCategory); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Update");
            }
        }

        /// <summary>
        /// Delete Category Master
        /// </summary>
        /// <param name="_objCategory"></param>
        /// <returns></returns>
        public static async Task<int> Delete(CategoryModel _objCategory)
        {
            try
            {
                int result = 0;
                DTOMstCategory _objDtoCategory = new DTOMstCategory()
                {
                    Cat_Id = _objCategory.Cat_Id,
                    Cat_Name = _objCategory.Cat_Name,
                    Res_Id = _objCategory.Res_Id,
                };
                result = await Task.Run(() => { return _dalMstCategory.Delete(_objDtoCategory); });
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
