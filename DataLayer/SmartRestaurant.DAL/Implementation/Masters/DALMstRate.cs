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
    public class DALMstRate : IMstRate
    {
        public int Create(DTOMstRate data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Rate_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Insert");                   
                    cmd.Parameters.AddWithValue("@Price", data.Price);
                    cmd.Parameters.AddWithValue("@Supplier_id", data.Supplier_id);
                    cmd.Parameters.AddWithValue("@Supplier_name", data.Supplier_name);
                    cmd.Parameters.AddWithValue("@Quantity", data.Quantity);
                    cmd.Parameters.AddWithValue("@Mcategory_id", data.Mcategory_id);
                    cmd.Parameters.AddWithValue("@Mcategory_name", data.Mcategory_name);
                    cmd.Parameters.AddWithValue("@Unit", data.Unit);
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

        public int Delete(DTOMstRate data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Rate_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Delete");
                    cmd.Parameters.AddWithValue("@Rate_id", data.Rate_id);
                    cmd.Parameters.AddWithValue("@Price", data.Price);
                    cmd.Parameters.AddWithValue("@Supplier_id", data.Supplier_id);
                    cmd.Parameters.AddWithValue("@Supplier_name", data.Supplier_name);
                    cmd.Parameters.AddWithValue("@Quantity", data.Quantity);
                    cmd.Parameters.AddWithValue("@Mcategory_id", data.Mcategory_id);
                    cmd.Parameters.AddWithValue("@Mcategory_name", data.Mcategory_name);
                    cmd.Parameters.AddWithValue("@Unit", data.Unit);

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

        public int Edit(DTOMstRate data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Rate_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Update");
                    cmd.Parameters.AddWithValue("@Rate_id", data.Rate_id);
                    cmd.Parameters.AddWithValue("@Price", data.Price);
                    cmd.Parameters.AddWithValue("@Supplier_id", data.Supplier_id);
                    cmd.Parameters.AddWithValue("@Supplier_name", data.Supplier_name);
                    cmd.Parameters.AddWithValue("@Quantity", data.Quantity);
                    cmd.Parameters.AddWithValue("@Mcategory_id", data.Mcategory_id);
                    cmd.Parameters.AddWithValue("@Mcategory_name", data.Mcategory_name);
                    cmd.Parameters.AddWithValue("@Unit", data.Unit);
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

        public List<DTOMstRate> GetAll(int resId)
        {
            try
            {
                List<DTOMstRate> lstMstRate = new List<DTOMstRate>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Rate_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstRate objDTOMstRate = new DTOMstRate();

                        objDTOMstRate.Supplier_id = Convert.ToInt32(dr["Supplier_id"].ToString());
                        objDTOMstRate.Price = dr["Price"].ToString();
                        objDTOMstRate.Rate_id = Convert.ToInt32(dr["Rate_id"].ToString());
                        //objDTOMstRate.ActiveFlg = dr["ActiveFlg"].ToString();
                        //objDTOMstRate.IntInserted_by = dr["IntInserted_by"].ToString();
                        //objDTOMstRate.Inserted_date = dr["Inserted_date"].ToString();
                        //objDTOMstRate.InseretIP = dr["InseretIP"].ToString();
                        //objDTOMstRate.IntUpdate_by = dr["IntUpdate_by"].ToString();
                        //objDTOMstRate.Updated_date = dr["Updated_date"].ToString();
                        //objDTOMstRate.UpdateIP = dr["UpdateIP"].ToString();
                        //objDTOMstRate.IntDelete_by = dr["IntDelete_by"].ToString();
                        //objDTOMstRate.Deleted_date = dr["Deleted_date"].ToString();
                        //objDTOMstRate.DeleteIP = dr["DeleteIP"].ToString();
                        //objDTOMstRate.Url_Rate = dr["Url_Rate"].ToString();
                        lstMstRate.Add(objDTOMstRate);
                    }
                    con.Close();
                }
                return lstMstRate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTOMstRate GetExisting(int code,int resId)
        {
            try
            {
                DTOMstRate objDTOMstRate = new DTOMstRate();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Rate_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Edit");
                    cmd.Parameters.AddWithValue("@Supplier_id", code);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        objDTOMstRate.Supplier_id = Convert.ToInt32(dr["Supplier_id"].ToString());
                        objDTOMstRate.Price = dr["Price"].ToString();
                    }
                    con.Close();
                }
                return objDTOMstRate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
