using SmartRestaurant.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.DAL
{
    public class DALMstUserType: IMstUserType
    {
        public int Create(DTOMstUserType data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UserType_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Insert");
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
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

        public int Delete(DTOMstUserType data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UserType_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Delete");
                    cmd.Parameters.AddWithValue("@User_Id", data.User_Id);
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
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

        public int Edit(DTOMstUserType data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UserType_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Update");
                    cmd.Parameters.AddWithValue("@User_Id", data.User_Id);
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
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

        public List<DTOMstUserType> GetAll(int resId)
        {
            try
            {
                List<DTOMstUserType> lstMstUserType = new List<DTOMstUserType>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UserType_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");
                    cmd.Parameters.AddWithValue("@Res_Id", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstUserType objDTOMstUserType = new DTOMstUserType();

                        objDTOMstUserType.User_Id = Convert.ToInt32(dr["User_Id"].ToString());
                        objDTOMstUserType.User_Name = dr["User_Name"].ToString();
                        objDTOMstUserType.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        lstMstUserType.Add(objDTOMstUserType);
                    }
                    con.Close();
                }
                return lstMstUserType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTOMstUserType GetExisting(int code,int resId)
        {
            try
            {
                DTOMstUserType objDTOMstUserType = new DTOMstUserType();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("UserType_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Edit");
                    cmd.Parameters.AddWithValue("@User_Id", code);
                    cmd.Parameters.AddWithValue("@Res_Id", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        objDTOMstUserType.User_Id = Convert.ToInt32(dr["User_Id"].ToString());
                        objDTOMstUserType.User_Name = dr["User_Name"].ToString();
                    }
                    con.Close();
                }
                return objDTOMstUserType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
