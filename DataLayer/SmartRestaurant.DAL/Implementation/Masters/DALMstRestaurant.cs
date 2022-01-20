using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SmartRestaurant.DTO;

namespace SmartRestaurant.DAL
{
    public class DALMstRestaurant : IMstRestaurant
    {
        public int Create(DTOMstRestaurant data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Restaurant_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Insert");
                    cmd.Parameters.AddWithValue("@Res_Name", data.Res_Name);
                    cmd.Parameters.AddWithValue("@Res_Area", data.Res_Area);
                    cmd.Parameters.AddWithValue("@Res_Type", data.Res_Type);
                    cmd.Parameters.AddWithValue("@Res_Phone", data.Res_Phone);
                    cmd.Parameters.AddWithValue("@Res_Email", data.Res_Email);
                    cmd.Parameters.AddWithValue("@Res_GSTIN", data.Res_GSTIN);
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

        public int Delete(DTOMstRestaurant data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Restaurant_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ResId", "1");
                    cmd.Parameters.AddWithValue("@command", "Delete");
                    cmd.Parameters.AddWithValue("@Res_Name", data.Res_Name);
                    cmd.Parameters.AddWithValue("@Res_Area", data.Res_Area);
                    cmd.Parameters.AddWithValue("@Res_Type", data.Res_Type);
                    cmd.Parameters.AddWithValue("@Res_Phone", data.Res_Phone);
                    cmd.Parameters.AddWithValue("@Res_Email", data.Res_Email);
                    cmd.Parameters.AddWithValue("@Res_GSTIN", data.Res_GSTIN);
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

        public int Edit(DTOMstRestaurant data)
        {
            try
            {
                int result = 0;
                
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Restaurant_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ResId", "1");
                    cmd.Parameters.AddWithValue("@command", "Update");
                    cmd.Parameters.AddWithValue("@Res_Name", data.Res_Name);
                    cmd.Parameters.AddWithValue("@Res_Area", data.Res_Area);
                    cmd.Parameters.AddWithValue("@Res_Type", data.Res_Type);
                    cmd.Parameters.AddWithValue("@Res_Phone", data.Res_Phone);
                    cmd.Parameters.AddWithValue("@Res_Email", data.Res_Email);
                    cmd.Parameters.AddWithValue("@Res_GSTIN", data.Res_GSTIN);
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

        public List<DTOMstRestaurant> GetAll(int resId)
        {
            try
            {
                List<DTOMstRestaurant> lstMstRestaurant = new List<DTOMstRestaurant>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Restaurant_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");
                    cmd.Parameters.AddWithValue("@ResId", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstRestaurant objDTOMstRestaurant = new DTOMstRestaurant();

                        objDTOMstRestaurant.ResId = dr["ResId"].ToString();//dr.GetString(dr.GetOrdinal("ResId"));//
                        objDTOMstRestaurant.Res_Name = dr["ResName"].ToString();
                        objDTOMstRestaurant.Res_Area = dr["Address"].ToString();
                        objDTOMstRestaurant.Res_Email = dr["Email"].ToString();
                        objDTOMstRestaurant.Res_Type = dr["ResType"].ToString();
                        objDTOMstRestaurant.Res_Phone = dr["Mobile"].ToString();
                        objDTOMstRestaurant.Res_GSTIN = dr["GSTIN"].ToString();                        
                        lstMstRestaurant.Add(objDTOMstRestaurant);
                    }
                    con.Close();
                }
                return lstMstRestaurant;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTOMstRestaurant GetExisting(int code,int resId)
        {
            try
            {
                DTOMstRestaurant objDTOMstRestaurant = new DTOMstRestaurant();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Restaurant_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");
                    cmd.Parameters.AddWithValue("@ResId", resId);                    
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        objDTOMstRestaurant.ResId = dr["ResId"].ToString();//dr.GetString(dr.GetOrdinal("ResId"));//
                        objDTOMstRestaurant.Res_Name = dr["ResName"].ToString();
                        objDTOMstRestaurant.Res_Area = dr["Address"].ToString();
                        objDTOMstRestaurant.Res_Email = dr["Email"].ToString();
                        objDTOMstRestaurant.Res_Type = dr["ResType"].ToString();
                        objDTOMstRestaurant.Res_Phone = dr["Mobile"].ToString();
                        objDTOMstRestaurant.Res_GSTIN = dr["GSTIN"].ToString();
                        
                    }
                    con.Close();
                }
                return objDTOMstRestaurant;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int RegisterNewRestaurant(DTOMstRestaurant data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    //SqlCommand cmd = new SqlCommand("Restaurant_SP", con);
                    SqlCommand cmd = new SqlCommand("INSERT INTO RestaurantMaster (Res_Name,Res_Area,Res_Type,Res_Email,ActiveFlg) OUTPUT inserted.Res_Id VALUES (@Res_Name,@Res_Area,@Res_Type,@Res_Email,@ActiveFlg)", con);
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@command", "Insert");
                    cmd.Parameters.AddWithValue("@Res_Name", data.Res_Name);
                    cmd.Parameters.AddWithValue("@Res_Area", data.Res_Area);
                    cmd.Parameters.AddWithValue("@Res_Type", data.Res_Type);
                    //cmd.Parameters.AddWithValue("@Res_Phone", data.Res_Phone);
                    cmd.Parameters.AddWithValue("@Res_Email", data.Res_Email);
                    cmd.Parameters.AddWithValue("@ActiveFlg", "1");
                    
                    //cmd.Parameters.AddWithValue("@Res_GSTIN", data.Res_GSTIN);
                    con.Open();
                    result = (int) cmd.ExecuteScalar();

                    con.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
