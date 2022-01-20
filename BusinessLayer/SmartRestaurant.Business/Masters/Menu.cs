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
    public class Menu : BaseBusiness
    {
        public static IMstMenu _dalMstMenu;

        #region New instance,Select
        /// <summary>
        /// For create new Instance of Menu Class
        /// </summary>
        /// <returns></returns>
        public static MenuModel New()
        {
            try
            {
                return new MenuModel();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Failed. " + ex.Message);
            }
        }

        /// <summary>
        /// Get All data from Menu Master
        /// </summary>
        /// <returns></returns>
        public static List<MenuModel> GetAll(int resId)
        {
            try
            {
                _dalMstMenu = new DALMstMenu();
                return fillMenuList(_dalMstMenu.GetAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get All data from Menu Master
        /// </summary>
        /// <returns></returns>
        public static async Task<List<MenuModel>> GetAllAsync(int resId)
        {
            try
            {
                _dalMstMenu = new DALMstMenu();
                List<MenuModel> lstMenu = await Task.Run(() => { return fillMenuList(_dalMstMenu.GetAll(resId)); });
                return lstMenu;
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get Existing Menu data by Menu_Id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<MenuModel> GetExistingAsync(int code, int resId)
        {
            try
            {
                _dalMstMenu = new DALMstMenu();
                DTOMstMenu dtoMstMenu = await Task.Run(() => { return _dalMstMenu.GetExisting(code, resId); });
                return new MenuModel()
                {
                    // Add Column here                    
                    Menu_Id = dtoMstMenu.Menu_Id,
                    Menu_Name = dtoMstMenu.Menu_Name,
                    Menu_Type = dtoMstMenu.Menu_Type,
                    Cat_Id = dtoMstMenu.Cat_Id,
                    Food_Code = dtoMstMenu.Food_Code,
                    Price = dtoMstMenu.Price,
                    Res_id = 1,
                };
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<MenuModel> fillMenuList(List<DTOMstMenu> _objDtoMstMenu)
        {
            var list = from dtoMstMenu in _objDtoMstMenu
                       select new MenuModel()
                       {
                           // Add your Column here

                           Menu_Id = dtoMstMenu.Menu_Id,
                           Menu_Name = dtoMstMenu.Menu_Name,
                           Menu_Type = dtoMstMenu.Menu_Type,
                           Cat_Id = dtoMstMenu.Cat_Id,
                           Food_Code = dtoMstMenu.Food_Code,
                           Price = dtoMstMenu.Price,
                           Cat_Name = dtoMstMenu.Cat_Name,
                           Res_id = dtoMstMenu.Res_id,

                       };
            return list.AsEnumerable<MenuModel>().ToList();
        }
        #endregion

        #region Insert,Update,Delete
        /// <summary>
        /// Insert data in Menu Master
        /// </summary>
        /// <param name="_objMenu"></param>
        /// <returns></returns>
        public static async Task<int> Create(MenuModel _objMenu)
        {
            try
            {
                int result = 0;
                _dalMstMenu = new DALMstMenu();
                DTOMstMenu _objDtoMenu = new DTOMstMenu()
                {
                    // Add your Column here

                    Menu_Id = _objMenu.Menu_Id,
                    Menu_Name = _objMenu.Menu_Name,
                    Menu_Type = _objMenu.Menu_Type,
                    Cat_Id = _objMenu.Cat_Id,
                    Food_Code = _objMenu.Food_Code,
                    Price = _objMenu.Price,
                    Res_id = _objMenu.Res_id,
                };
                result = await Task.Run(() => { return _dalMstMenu.Create(_objDtoMenu); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Insert");
            }
        }

        /// <summary>
        /// Update Menu Master
        /// </summary>
        /// <param name="_objMenu"></param>
        /// <returns></returns>
        public static async Task<int> Edit(MenuModel _objMenu)
        {
            try
            {
                int result = 0;
                DTOMstMenu _objDtoMenu = new DTOMstMenu()
                {
                    // Add your Column here

                    Menu_Id = _objMenu.Menu_Id,
                    Menu_Name = _objMenu.Menu_Name,
                    Menu_Type = _objMenu.Menu_Type,
                    Cat_Id = _objMenu.Cat_Id,
                    Food_Code = _objMenu.Food_Code,
                    Price = _objMenu.Price,
                    Res_id = _objMenu.Res_id,
                };
                result = await Task.Run(() => { return _dalMstMenu.Edit(_objDtoMenu); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Update");
            }
        }

        /// <summary>
        /// Delete Menu Master
        /// </summary>
        /// <param name="_objMenu"></param>
        /// <returns></returns>
        public static async Task<int> Delete(MenuModel _objMenu)
        {
            try
            {
                int result = 0;
                DTOMstMenu _objDtoMenu = new DTOMstMenu()
                {
                    Menu_Id = _objMenu.Menu_Id,
                    Menu_Name = _objMenu.Menu_Name,
                    Menu_Type = _objMenu.Menu_Type,
                    Cat_Id = _objMenu.Cat_Id,
                    Food_Code = _objMenu.Food_Code,
                    Price = _objMenu.Price,
                    Res_id = _objMenu.Res_id,
                };
                result = await Task.Run(() => { return _dalMstMenu.Delete(_objDtoMenu); });
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
