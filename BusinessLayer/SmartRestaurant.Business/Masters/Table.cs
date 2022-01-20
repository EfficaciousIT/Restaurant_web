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
    public class Table : BaseBusiness
    {
        public static IMstTable _dalMstTable;

        #region New instance,Select
        /// <summary>
        /// For create new Instance of Table Class
        /// </summary>
        /// <returns></returns>
        public static TableModel New()
        {
            try
            {
                return new TableModel();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Failed. " + ex.Message);
            }
        }

        /// <summary>
        /// Get All data from Table Master
        /// </summary>
        /// <returns></returns>
        public static List<TableModel> GetAll(int resId)
        {
            try
            {
                _dalMstTable = new DALMstTable();
                return fillTableList(_dalMstTable.GetAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get All data from Table Master
        /// </summary>
        /// <returns></returns>
        public static async Task<List<TableModel>> GetAllAsync(int resId)
        {
            try
            {
                _dalMstTable = new DALMstTable();
                List<TableModel> lstTable = await Task.Run(() => { return fillTableList(_dalMstTable.GetAll(resId)); });
                return lstTable;
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get Existing Table data by Table_Id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<TableModel> GetExistingAsync(int code,int resId)
        {
            try
            {
                _dalMstTable = new DALMstTable();
                DTOMstTable dtoMstTable = await Task.Run(() => { return _dalMstTable.GetExisting(code, resId); });
                return new TableModel()
                {
                    // Add Column here                    

                    Table_Id = dtoMstTable.Table_Id,
                    Table_Name = dtoMstTable.Table_Name,
                    Res_Id = 1,                    
                };
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<TableModel> fillTableList(List<DTOMstTable> _objDtoMstTable)
        {
            var list = from dtoMstTable in _objDtoMstTable
                       select new TableModel()
                       {
                           // Add your Column here

                           Table_Id = dtoMstTable.Table_Id,
                           Table_Name = dtoMstTable.Table_Name,
                           Res_Id = dtoMstTable.Res_Id,

                       };
            return list.AsEnumerable<TableModel>().ToList();
        }
        #endregion

        #region Insert,Update,Delete
        /// <summary>
        /// Insert data in Table Master
        /// </summary>
        /// <param name="_objTable"></param>
        /// <returns></returns>
        public static async Task<int> Create(TableModel _objTable)
        {
            try
            {
                int result = 0;
                _dalMstTable = new DALMstTable();
                
                DTOMstTable _objDtoTable = new DTOMstTable()
                {
                    // Add your Column here
                    Table_Id = _objTable.Table_Id,
                    Table_Name = _objTable.Table_Name,
                    Res_Id = _objTable.Res_Id,
                };
                result = await Task.Run(() => { return _dalMstTable.Create(_objDtoTable); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Insert");
            }
        }

        /// <summary>
        /// Update Table Master
        /// </summary>
        /// <param name="_objTable"></param>
        /// <returns></returns>
        public static async Task<int> Edit(TableModel _objTable)
        {
            try
            {
                int result = 0;
                DTOMstTable _objDtoTable = new DTOMstTable()
                {
                    // Add your Column here

                    Table_Id = _objTable.Table_Id,
                    Table_Name = _objTable.Table_Name,
                    Res_Id = _objTable.Res_Id,
                };
                result = await Task.Run(() => { return _dalMstTable.Edit(_objDtoTable); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Update");
            }
        }

        /// <summary>
        /// Delete Table Master
        /// </summary>
        /// <param name="_objTable"></param>
        /// <returns></returns>
        public static async Task<int> Delete(TableModel _objTable)
        {
            try
            {
                int result = 0;
                DTOMstTable _objDtoTable = new DTOMstTable()
                {
                    Table_Id = _objTable.Table_Id,
                    Table_Name = _objTable.Table_Name,
                    Res_Id = _objTable.Res_Id,
                };
                result = await Task.Run(() => { return _dalMstTable.Delete(_objDtoTable); });
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
