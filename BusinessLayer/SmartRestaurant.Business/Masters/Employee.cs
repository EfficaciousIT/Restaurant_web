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
    public class Employee : BaseBusiness
    {
        public static IMstEmployee _dalMstEmployee;

        #region New instance,Select
        /// <summary>
        /// For create new Instance of Employee Class
        /// </summary>
        /// <returns></returns>
        public static EmployeeModel New()
        {
            try
            {
                return new EmployeeModel();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Failed. " + ex.Message);
            }
        }

        /// <summary>
        /// Get All data from Employee Master
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeModel> GetAll(int resId)
        {
            try
            {
                _dalMstEmployee = new DALMstEmployee();
                return fillEmployeeList(_dalMstEmployee.GetAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        public static List<EmployeeModel> GetAllEmployee(int resId)
        {
            try
            {
                _dalMstEmployee = new DALMstEmployee();
                return fillEmployeeList(_dalMstEmployee.GetEmployeeAll(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }
        /// <summary>
        /// Get All data from Employee Master
        /// </summary>
        /// <returns></returns>
        public static async Task<List<EmployeeModel>> GetAllAsync(int resId)
        {
            try
            {
                _dalMstEmployee = new DALMstEmployee();
                List<EmployeeModel> lstEmployee = await Task.Run(() => { return fillEmployeeList(_dalMstEmployee.GetAll(resId)); });
                return lstEmployee;
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        /// <summary>
        /// Get Existing Employee data by Employee_Id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<EmployeeModel> GetExistingAsync(int code,int resId)
        {
            try
            {
                _dalMstEmployee = new DALMstEmployee();
                DTOMstEmployee dtoMstEmployee = await Task.Run(() => { return _dalMstEmployee.GetExisting(code, resId); });
                return new EmployeeModel()
                {
                    // Add Column here                    
                    Employee_Id = dtoMstEmployee.Employee_Id,
                    First_Name = dtoMstEmployee.First_Name,
                    Middle_Name = dtoMstEmployee.Middle_Name,
                    Last_Name = dtoMstEmployee.Last_Name,
                    Mobile_No = dtoMstEmployee.Mobile_No,
                    Email_Id = dtoMstEmployee.Email_Id,
                    Address_1 = dtoMstEmployee.Address_1,
                    Address_2 = dtoMstEmployee.Address_2,
                    Address_3 = dtoMstEmployee.Address_3,
                    Gender = dtoMstEmployee.Gender,
                    Res_Id = dtoMstEmployee.Res_Id,
                    Imei_No = dtoMstEmployee.Imei_No,
                    vchProfile = dtoMstEmployee.vchProfile,
                    vchFcmToken = dtoMstEmployee.vchFcmToken,
                    CreatedDate = dtoMstEmployee.CreatedDate,
                    ActiveFlg = dtoMstEmployee.ActiveFlg,
                    IntInserted_by = dtoMstEmployee.IntInserted_by,
                    Inserted_date = dtoMstEmployee.Inserted_date,
                    InseretIP = dtoMstEmployee.InseretIP,
                    IntUpdate_by = dtoMstEmployee.IntUpdate_by,
                    Updated_date = dtoMstEmployee.Updated_date,
                    UpdateIP = dtoMstEmployee.UpdateIP,
                    IntDelete_by = dtoMstEmployee.IntDelete_by,
                    Deleted_date = dtoMstEmployee.Deleted_date,
                    DeleteIP = dtoMstEmployee.DeleteIP,
                };
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<EmployeeModel> fillEmployeeList(List<DTOMstEmployee> _objDtoMstEmployee)
        {
            var list = from dtoMstEmployee in _objDtoMstEmployee
                       select new EmployeeModel()
                       {
                           // Add your Column here

                           Employee_Id = dtoMstEmployee.Employee_Id,
                           //fullName = dtoMstEmployee.First_Name +" "+ dtoMstEmployee.Middle_Name.Substring(1,1)+". "+ dtoMstEmployee.Last_Name,
                           First_Name = dtoMstEmployee.First_Name,
                           Middle_Name = dtoMstEmployee.Middle_Name,
                           Last_Name = dtoMstEmployee.Last_Name,
                           Mobile_No = dtoMstEmployee.Mobile_No,
                           Email_Id = dtoMstEmployee.Email_Id,
                           Address_1 = dtoMstEmployee.Address_1,
                           Address_2 = dtoMstEmployee.Address_2,
                           Address_3 = dtoMstEmployee.Address_3,
                           Gender = dtoMstEmployee.Gender,
                           Res_Id = dtoMstEmployee.Res_Id,
                           Imei_No = dtoMstEmployee.Imei_No,
                           vchProfile = dtoMstEmployee.vchProfile,
                           vchFcmToken = dtoMstEmployee.vchFcmToken,
                           CreatedDate = dtoMstEmployee.CreatedDate,
                           ActiveFlg = dtoMstEmployee.ActiveFlg,
                           IntInserted_by = dtoMstEmployee.IntInserted_by,
                           Inserted_date = dtoMstEmployee.Inserted_date,
                           InseretIP = dtoMstEmployee.InseretIP,
                           IntUpdate_by = dtoMstEmployee.IntUpdate_by,
                           Updated_date = dtoMstEmployee.Updated_date,
                           UpdateIP = dtoMstEmployee.UpdateIP,
                           IntDelete_by = dtoMstEmployee.IntDelete_by,
                           Deleted_date = dtoMstEmployee.Deleted_date,
                           DeleteIP = dtoMstEmployee.DeleteIP,

                       };
            return list.AsEnumerable<EmployeeModel>().ToList();
        }
        #endregion

        #region Insert,Update,Delete
        /// <summary>
        /// Insert data in Employee Master
        /// </summary>
        /// <param name="_objEmployee"></param>
        /// <returns></returns>
        public static async Task<int> Create(EmployeeModel _objEmployee)
        {
            try
            {
                int result = 0;
                _dalMstEmployee = new DALMstEmployee();
                DTOMstEmployee _objDtoEmployee = new DTOMstEmployee()
                {
                    // Add your Column here
                    Employee_Id = _objEmployee.Employee_Id,
                    First_Name = _objEmployee.First_Name,
                    Middle_Name = _objEmployee.Middle_Name,
                    Last_Name = _objEmployee.Last_Name,
                    Mobile_No = _objEmployee.Mobile_No,
                    Email_Id = _objEmployee.Email_Id,
                    Address_1 = _objEmployee.Address_1,
                    Address_2 = _objEmployee.Address_2,
                    Address_3 = _objEmployee.Address_3,
                    Gender = _objEmployee.Gender,
                    Res_Id =_objEmployee.Res_Id,
                    Imei_No = _objEmployee.Imei_No,
                    vchProfile = _objEmployee.vchProfile,
                    vchFcmToken = _objEmployee.vchFcmToken,
                    CreatedDate = _objEmployee.CreatedDate,
                    ActiveFlg = _objEmployee.ActiveFlg,
                    IntInserted_by = _objEmployee.IntInserted_by,
                    Inserted_date = _objEmployee.Inserted_date,
                    InseretIP = _objEmployee.InseretIP,
                    IntUpdate_by = _objEmployee.IntUpdate_by,
                    Updated_date = _objEmployee.Updated_date,
                    UpdateIP = _objEmployee.UpdateIP,
                    IntDelete_by = _objEmployee.IntDelete_by,
                    Deleted_date = _objEmployee.Deleted_date,
                    DeleteIP = _objEmployee.DeleteIP,
                };
                result = await Task.Run(() => { return _dalMstEmployee.Create(_objDtoEmployee); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Insert");
            }
        }

        /// <summary>
        /// Update Employee Master
        /// </summary>
        /// <param name="_objEmployee"></param>
        /// <returns></returns>
        public static async Task<int> Edit(EmployeeModel _objEmployee)
        {
            try
            {
                int result = 0;
                DTOMstEmployee _objDtoEmployee = new DTOMstEmployee()
                {
                    // Add your Column here
                    Employee_Id = _objEmployee.Employee_Id,
                    First_Name = _objEmployee.First_Name,
                    Middle_Name = _objEmployee.Middle_Name,
                    Last_Name = _objEmployee.Last_Name,
                    Mobile_No = _objEmployee.Mobile_No,
                    Email_Id = _objEmployee.Email_Id,
                    Address_1 = _objEmployee.Address_1,
                    Address_2 = _objEmployee.Address_2,
                    Address_3 = _objEmployee.Address_3,
                    Gender = _objEmployee.Gender,
                    Res_Id = _objEmployee.Res_Id,
                    Imei_No = _objEmployee.Imei_No,
                    vchProfile = _objEmployee.vchProfile,
                    vchFcmToken = _objEmployee.vchFcmToken,
                    CreatedDate = _objEmployee.CreatedDate,
                    ActiveFlg = _objEmployee.ActiveFlg,
                    IntInserted_by = _objEmployee.IntInserted_by,
                    Inserted_date = _objEmployee.Inserted_date,
                    InseretIP = _objEmployee.InseretIP,
                    IntUpdate_by = _objEmployee.IntUpdate_by,
                    Updated_date = _objEmployee.Updated_date,
                    UpdateIP = _objEmployee.UpdateIP,
                    IntDelete_by = _objEmployee.IntDelete_by,
                    Deleted_date = _objEmployee.Deleted_date,
                    DeleteIP = _objEmployee.DeleteIP,
                };
                result = await Task.Run(() => { return _dalMstEmployee.Edit(_objDtoEmployee); });
                return result;
            }
            catch
            {
                throw new Exception("Failed To Update");
            }
        }

        /// <summary>
        /// Delete Employee Master
        /// </summary>
        /// <param name="_objEmployee"></param>
        /// <returns></returns>
        public static async Task<int> Delete(EmployeeModel _objEmployee)
        {
            try
            {
                int result = 0;
                DTOMstEmployee _objDtoEmployee = new DTOMstEmployee()
                {
                    Employee_Id = _objEmployee.Employee_Id,
                    First_Name = _objEmployee.First_Name,
                    Middle_Name = _objEmployee.Middle_Name,
                    Last_Name = _objEmployee.Last_Name,
                    Mobile_No = _objEmployee.Mobile_No,
                    Email_Id = _objEmployee.Email_Id,
                    Address_1 = _objEmployee.Address_1,
                    Address_2 = _objEmployee.Address_2,
                    Address_3 = _objEmployee.Address_3,
                    Gender = _objEmployee.Gender,
                    Res_Id = _objEmployee.Res_Id,
                    Imei_No = _objEmployee.Imei_No,
                    vchProfile = _objEmployee.vchProfile,
                    vchFcmToken = _objEmployee.vchFcmToken,
                    CreatedDate = _objEmployee.CreatedDate,
                    ActiveFlg = _objEmployee.ActiveFlg,
                    IntInserted_by = _objEmployee.IntInserted_by,
                    Inserted_date = _objEmployee.Inserted_date,
                    InseretIP = _objEmployee.InseretIP,
                    IntUpdate_by = _objEmployee.IntUpdate_by,
                    Updated_date = _objEmployee.Updated_date,
                    UpdateIP = _objEmployee.UpdateIP,
                    IntDelete_by = _objEmployee.IntDelete_by,
                    Deleted_date = _objEmployee.Deleted_date,
                    DeleteIP = _objEmployee.DeleteIP,
                };
                result = await Task.Run(() => { return _dalMstEmployee.Delete(_objDtoEmployee); });
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
