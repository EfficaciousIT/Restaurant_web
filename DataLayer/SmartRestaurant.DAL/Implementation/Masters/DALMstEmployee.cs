using Dapper;
using SmartRestaurant.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SmartRestaurant.DAL
{
    public class DALMstEmployee : IMstEmployee
    {
        public int Create(DTOMstEmployee data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Employee_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Insert");

                    cmd.Parameters.AddWithValue("@Employee_Id", data.Employee_Id);
                    cmd.Parameters.AddWithValue("@First_Name", data.First_Name);
                    cmd.Parameters.AddWithValue("@Middle_Name", data.Middle_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", data.Last_Name);
                    cmd.Parameters.AddWithValue("@Gender", data.Gender);
                    cmd.Parameters.AddWithValue("@Mobile_No", data.Mobile_No);
                    cmd.Parameters.AddWithValue("@Email_Id", data.Email_Id);
                    cmd.Parameters.AddWithValue("@Address_1", data.Address_1);
                    cmd.Parameters.AddWithValue("@Address_2", data.Address_2);
                    cmd.Parameters.AddWithValue("@Address_3", data.Address_3);
                    cmd.Parameters.AddWithValue("@Res_id", data.Res_Id);
                    cmd.Parameters.AddWithValue("@vchProfile", data.vchProfile);
                    cmd.Parameters.AddWithValue("@vchFCMToken", data.vchFcmToken);
                    cmd.Parameters.AddWithValue("@Imei_no", data.Imei_No);
                    cmd.Parameters.AddWithValue("@IntInserted_by", data.IntInserted_by);
                    cmd.Parameters.AddWithValue("@InseretIP", data.InseretIP);
                    cmd.Parameters.AddWithValue("@IntUpdate_by", data.IntUpdate_by);
                    cmd.Parameters.AddWithValue("@UpdateIP", data.UpdateIP);
                    cmd.Parameters.AddWithValue("@IntDelete_by", data.IntDelete_by);
                    cmd.Parameters.AddWithValue("@DeleteIP", data.DeleteIP);

                    con.Open();
                    result = cmd.ExecuteNonQuery();

                    con.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(DTOMstEmployee data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Employee_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Delete");                    
                    cmd.Parameters.AddWithValue("@Employee_Id", data.Employee_Id);
                    cmd.Parameters.AddWithValue("@First_Name", data.First_Name);
                    cmd.Parameters.AddWithValue("@Middle_Name", data.Middle_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", data.Last_Name);
                    cmd.Parameters.AddWithValue("@Gender", data.Gender);
                    cmd.Parameters.AddWithValue("@Mobile_No", data.Mobile_No);
                    cmd.Parameters.AddWithValue("@Email_Id", data.Email_Id);
                    cmd.Parameters.AddWithValue("@Address_1", data.Address_1);
                    cmd.Parameters.AddWithValue("@Address_2", data.Address_2);
                    cmd.Parameters.AddWithValue("@Address_3", data.Address_3);
                    cmd.Parameters.AddWithValue("@Res_id", data.Res_Id);
                    cmd.Parameters.AddWithValue("@vchProfile", data.vchProfile);
                    cmd.Parameters.AddWithValue("@vchFCMToken", data.vchFcmToken);
                    cmd.Parameters.AddWithValue("@Imei_no", data.Imei_No);
                    cmd.Parameters.AddWithValue("@IntInserted_by", data.IntInserted_by);
                    cmd.Parameters.AddWithValue("@InseretIP", data.InseretIP);
                    cmd.Parameters.AddWithValue("@IntUpdate_by", data.IntUpdate_by);
                    cmd.Parameters.AddWithValue("@UpdateIP", data.UpdateIP);
                    cmd.Parameters.AddWithValue("@IntDelete_by", data.IntDelete_by);
                    cmd.Parameters.AddWithValue("@DeleteIP", data.DeleteIP);
                    con.Open();
                    result = cmd.ExecuteNonQuery();

                    con.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Edit(DTOMstEmployee data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Employee_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Update");
                    cmd.Parameters.AddWithValue("@Employee_Id", data.Employee_Id);
                    cmd.Parameters.AddWithValue("@First_Name", data.First_Name);
                    cmd.Parameters.AddWithValue("@Middle_Name", data.Middle_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", data.Last_Name);
                    cmd.Parameters.AddWithValue("@Gender", data.Gender);
                    cmd.Parameters.AddWithValue("@Mobile_No", data.Mobile_No);
                    cmd.Parameters.AddWithValue("@Email_Id", data.Email_Id);
                    cmd.Parameters.AddWithValue("@Address_1", data.Address_1);
                    cmd.Parameters.AddWithValue("@Address_2", data.Address_2);
                    cmd.Parameters.AddWithValue("@Address_3", data.Address_3);
                    cmd.Parameters.AddWithValue("@Res_id", data.Res_Id);
                    cmd.Parameters.AddWithValue("@vchProfile", data.vchProfile);
                    cmd.Parameters.AddWithValue("@vchFCMToken", data.vchFcmToken);
                    cmd.Parameters.AddWithValue("@Imei_no", data.Imei_No);
                    cmd.Parameters.AddWithValue("@IntInserted_by", data.IntInserted_by);
                    cmd.Parameters.AddWithValue("@InseretIP", data.InseretIP);
                    cmd.Parameters.AddWithValue("@IntUpdate_by", data.IntUpdate_by);
                    cmd.Parameters.AddWithValue("@UpdateIP", data.UpdateIP);
                    cmd.Parameters.AddWithValue("@IntDelete_by", data.IntDelete_by);
                    cmd.Parameters.AddWithValue("@DeleteIP", data.DeleteIP);
                    con.Open();
                    result = cmd.ExecuteNonQuery();

                    con.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DTOMstEmployee> GetAll(int resId)
        {
            try
            {
                List<DTOMstEmployee> lstMstEmployee = new List<DTOMstEmployee>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Employee_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");
                    cmd.Parameters.AddWithValue("@Res_id", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstEmployee objDTOMstEmployee = new DTOMstEmployee();
                        objDTOMstEmployee.Employee_Id = Convert.ToInt32(dr["Employee_Id"].ToString());
                        objDTOMstEmployee.First_Name = dr["First_Name"].ToString();
                        objDTOMstEmployee.Middle_Name = dr["Middle_Name"].ToString();
                        objDTOMstEmployee.Last_Name = dr["Last_Name"].ToString();
                        objDTOMstEmployee.Mobile_No = dr["Mobile_No"].ToString();
                        objDTOMstEmployee.Email_Id = dr["Email_Id"].ToString();
                        objDTOMstEmployee.Address_1 = dr["Address_1"].ToString();
                        //objDTOMstEmployee.Address_2 = dr["Address_2"].ToString();
                        //objDTOMstEmployee.Address_3 = dr["Address_3"].ToString();
                        objDTOMstEmployee.Gender = dr["Gender"].ToString();
                        //objDTOMstEmployee.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        objDTOMstEmployee.Imei_No = dr["Imei_No"].ToString();
                        objDTOMstEmployee.vchProfile = dr["vchProfile"].ToString();
                        objDTOMstEmployee.vchFcmToken = dr["vchFcmToken"].ToString();
                        //objDTOMstEmployee.ActiveFlg = dr["ActiveFlg"].ToString();
                        //objDTOMstEmployee.IntInserted_by = dr["IntInserted_by"].ToString();
                        //objDTOMstEmployee.InseretIP = dr["InseretIP"].ToString();
                        //objDTOMstEmployee.IntUpdate_by = dr["IntUpdate_by"].ToString();
                        //objDTOMstEmployee.UpdateIP = dr["UpdateIP"].ToString();
                        //objDTOMstEmployee.IntDelete_by = dr["IntDelete_by"].ToString();
                        //objDTOMstEmployee.DeleteIP = dr["DeleteIP"].ToString();
                        lstMstEmployee.Add(objDTOMstEmployee);
                    }
                    con.Close();
                }
                return lstMstEmployee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTOMstEmployee GetExisting(int code, int resId)
        {
            try
            {
                DTOMstEmployee objDTOMstEmployee = new DTOMstEmployee();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Employee_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Edit");
                    cmd.Parameters.AddWithValue("@Employee_Id", code);
                    cmd.Parameters.AddWithValue("@Res_id", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        objDTOMstEmployee.Employee_Id = Convert.ToInt32(dr["Employee_Id"].ToString());
                        //objDTOMstEmployee.fullName = dr["fullName"].ToString();
                        objDTOMstEmployee.First_Name = dr["First_Name"].ToString();
                        objDTOMstEmployee.Middle_Name = dr["Middle_Name"].ToString();
                        objDTOMstEmployee.Last_Name = dr["Last_Name"].ToString();
                        objDTOMstEmployee.Mobile_No = dr["Mobile_No"].ToString();
                        objDTOMstEmployee.Email_Id = dr["Email_Id"].ToString();
                        objDTOMstEmployee.Address_1 = dr["Address_1"].ToString();
                        objDTOMstEmployee.Address_2 = dr["Address_2"].ToString();
                        objDTOMstEmployee.Address_3 = dr["Address_3"].ToString();
                        objDTOMstEmployee.Gender = dr["Gender"].ToString();
                        //objDTOMstEmployee.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        //objDTOMstEmployee.Imei_No = dr["Imei_No"].ToString();
                        //objDTOMstEmployee.vchProfile = dr["vchProfile"].ToString();
                        //objDTOMstEmployee.vchFcmToken = dr["vchFcmToken"].ToString();
                        //objDTOMstEmployee.ActiveFlg = dr["ActiveFlg"].ToString();
                        //objDTOMstEmployee.IntInserted_by = dr["IntInserted_by"].ToString();
                        //objDTOMstEmployee.InseretIP = dr["InseretIP"].ToString();
                        //objDTOMstEmployee.IntUpdate_by = dr["IntUpdate_by"].ToString();
                        //objDTOMstEmployee.UpdateIP = dr["UpdateIP"].ToString();
                        //objDTOMstEmployee.IntDelete_by = dr["IntDelete_by"].ToString();
                        //objDTOMstEmployee.DeleteIP = dr["DeleteIP"].ToString();
                    }
                    con.Close();
                }
                return objDTOMstEmployee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DTOMstEmployee> GetEmployeeAll(int resId)
        {
            try
            {
                List<DTOMstEmployee> lstMstEmployee = new List<DTOMstEmployee>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("User_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Employee");
                    cmd.Parameters.AddWithValue("@Res_Id", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstEmployee objDTOMstEmployee = new DTOMstEmployee();

                        objDTOMstEmployee.Employee_Id = Convert.ToInt32(dr["Employee_Id"].ToString());
                        objDTOMstEmployee.fullName = dr["fullName"].ToString();
                        objDTOMstEmployee.First_Name = dr["First_Name"].ToString();
                        objDTOMstEmployee.Middle_Name = dr["Middle_Name"].ToString();
                        objDTOMstEmployee.Last_Name = dr["Last_Name"].ToString();
                        objDTOMstEmployee.Mobile_No = dr["Mobile_No"].ToString();
                        objDTOMstEmployee.Email_Id = dr["Email_Id"].ToString();
                        objDTOMstEmployee.Address_1 = dr["Address_1"].ToString();
                        objDTOMstEmployee.Address_2 = dr["Address_2"].ToString();
                        objDTOMstEmployee.Address_3 = dr["Address_3"].ToString();
                        objDTOMstEmployee.Gender = dr["Gender"].ToString();
                        //objDTOMstEmployee.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        //objDTOMstEmployee.Imei_No = dr["Imei_No"].ToString();
                        //objDTOMstEmployee.vchProfile = dr["vchProfile"].ToString();
                        //objDTOMstEmployee.vchFcmToken = dr["vchFcmToken"].ToString();                        
                        //objDTOMstEmployee.ActiveFlg = dr["ActiveFlg"].ToString();
                        //objDTOMstEmployee.IntInserted_by = dr["IntInserted_by"].ToString();                        
                        //objDTOMstEmployee.InseretIP = dr["InseretIP"].ToString();
                        //objDTOMstEmployee.IntUpdate_by = dr["IntUpdate_by"].ToString();                        
                        //objDTOMstEmployee.UpdateIP = dr["UpdateIP"].ToString();
                        //objDTOMstEmployee.IntDelete_by = dr["IntDelete_by"].ToString();                        
                        //objDTOMstEmployee.DeleteIP = dr["DeleteIP"].ToString();
                        lstMstEmployee.Add(objDTOMstEmployee);
                    }
                    con.Close();
                }
                return lstMstEmployee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
