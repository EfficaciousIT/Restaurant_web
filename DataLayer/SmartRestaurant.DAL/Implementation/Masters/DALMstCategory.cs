using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SmartRestaurant.DTO;

namespace SmartRestaurant.DAL
{
    public class DALMstCategory : IMstCategory
    {
        public int Create(DTOMstCategory data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Category_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Insert");                    
                    cmd.Parameters.AddWithValue("@Cat_Name", data.Cat_Name);
                    cmd.Parameters.AddWithValue("@Res_Id", data.Res_Id);
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

        public int Delete(DTOMstCategory data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Category_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Delete");
                    cmd.Parameters.AddWithValue("@Cat_Id", data.Cat_Id);
                    cmd.Parameters.AddWithValue("@Cat_Name", data.Cat_Name);
                    cmd.Parameters.AddWithValue("@Res_Id", data.Res_Id);
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

        public int Edit(DTOMstCategory data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Category_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Update");
                    cmd.Parameters.AddWithValue("@Cat_Id", data.Cat_Id);
                    cmd.Parameters.AddWithValue("@Cat_Name", data.Cat_Name);
                    cmd.Parameters.AddWithValue("@Res_Id", data.Res_Id);
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

        public List<DTOMstCategory> GetAll(int resId)
        {
            try
            {
                List<DTOMstCategory> lstMstCategory = new List<DTOMstCategory>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Category_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");                    
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstCategory objDTOMstCategory = new DTOMstCategory();

                        objDTOMstCategory.Cat_Id = Convert.ToInt32(dr["Cat_Id"].ToString());
                        objDTOMstCategory.Cat_Name = dr["Cat_Name"].ToString();
                        objDTOMstCategory.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        //objDTOMstCategory.ActiveFlg = dr["ActiveFlg"].ToString();
                        //objDTOMstCategory.IntInserted_by = dr["IntInserted_by"].ToString();
                        //objDTOMstCategory.Inserted_date = dr["Inserted_date"].ToString();
                        //objDTOMstCategory.InseretIP = dr["InseretIP"].ToString();
                        //objDTOMstCategory.IntUpdate_by = dr["IntUpdate_by"].ToString();
                        //objDTOMstCategory.Updated_date = dr["Updated_date"].ToString();
                        //objDTOMstCategory.UpdateIP = dr["UpdateIP"].ToString();
                        //objDTOMstCategory.IntDelete_by = dr["IntDelete_by"].ToString();
                        //objDTOMstCategory.Deleted_date = dr["Deleted_date"].ToString();
                        //objDTOMstCategory.DeleteIP = dr["DeleteIP"].ToString();
                        //objDTOMstCategory.Url_Category = dr["Url_Category"].ToString();
                        lstMstCategory.Add(objDTOMstCategory);
                    }
                    con.Close();
                }
                return lstMstCategory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTOMstCategory GetExisting(int code, int resId)
        {
            try
            {
                DTOMstCategory objDTOMstCategory = new DTOMstCategory();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Category_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Edit");
                    cmd.Parameters.AddWithValue("@Cat_Id", code);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        objDTOMstCategory.Cat_Id = Convert.ToInt32(dr["Cat_Id"].ToString());
                        objDTOMstCategory.Cat_Name = dr["Cat_Name"].ToString();                        
                    }
                    con.Close();
                }
                return objDTOMstCategory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
