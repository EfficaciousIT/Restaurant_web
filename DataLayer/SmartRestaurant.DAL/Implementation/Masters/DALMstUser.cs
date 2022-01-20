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
    public class DALMstUser: IMstUser
    {
        public DTOMstUser CheckLogin(DTOMstUser data)
        {
            try
            {
                DTOMstUser objDTOMstUser = new DTOMstUser();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Login_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Login");
                    cmd.Parameters.AddWithValue("@Username", data.User_Name);
                    cmd.Parameters.AddWithValue("@Password", data.Password);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {                      
                        objDTOMstUser.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        objDTOMstUser.UserType_Id = Convert.ToInt32(dr["UserType_Id"].ToString());
                        objDTOMstUser.Employee_Id = Convert.ToInt32(dr["Employee_Id"].ToString());
                        objDTOMstUser.User_Name = dr["User_Name"].ToString();
                        //objDTOMstUser.ActiveFlg = dr["ActiveFlg"].ToString();                        
                    }
                    con.Close();
                }
                return objDTOMstUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Create(DTOMstUser data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("User_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Insert");
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
                    cmd.Parameters.AddWithValue("@Res_Id", data.Res_Id);
                    cmd.Parameters.AddWithValue("@Employee_Id", data.Employee_Id);
                    cmd.Parameters.AddWithValue("@UserType_Id", data.UserType_Id);                    
                    cmd.Parameters.AddWithValue("@Password", data.Password);
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

        public int Delete(DTOMstUser data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("User_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Delete");
                    cmd.Parameters.AddWithValue("@Id", data.Id);
                    cmd.Parameters.AddWithValue("@Employee_Id", data.Employee_Id);
                    cmd.Parameters.AddWithValue("@Res_Id", data.Res_Id);
                    cmd.Parameters.AddWithValue("@UserType_Id", data.UserType_Id);
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
                    cmd.Parameters.AddWithValue("@Password", data.Password);
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

        public int Edit(DTOMstUser data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("User_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Update");
                    cmd.Parameters.AddWithValue("@Id", data.Id);
                    cmd.Parameters.AddWithValue("@Employee_Id", data.Employee_Id);
                    cmd.Parameters.AddWithValue("@Res_Id", data.Res_Id);
                    cmd.Parameters.AddWithValue("@UserType_Id", data.UserType_Id);
                    cmd.Parameters.AddWithValue("@User_Name", data.User_Name);
                    cmd.Parameters.AddWithValue("@Password", data.Password);
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

        public List<DTOMstUser> GetAll(int resId)
        {
            try
            {
                List<DTOMstUser> lstMstUser = new List<DTOMstUser>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("User_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");
                    cmd.Parameters.AddWithValue("@Res_Id", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstUser objDTOMstUser = new DTOMstUser();

                        objDTOMstUser.Id = Convert.ToInt32(dr["Id"].ToString());
                        objDTOMstUser.User_Name = dr["User_Name"].ToString();
                        objDTOMstUser.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        //objDTOMstUser.ActiveFlg = dr["ActiveFlg"].ToString();
                        //objDTOMstUser.IntInserted_by = dr["IntInserted_by"].ToString();
                        //objDTOMstUser.Inserted_date = dr["Inserted_date"].ToString();
                        //objDTOMstUser.InseretIP = dr["InseretIP"].ToString();
                        //objDTOMstUser.IntUpdate_by = dr["IntUpdate_by"].ToString();
                        //objDTOMstUser.Updated_date = dr["Updated_date"].ToString();
                        //objDTOMstUser.UpdateIP = dr["UpdateIP"].ToString();
                        //objDTOMstUser.IntDelete_by = dr["IntDelete_by"].ToString();
                        //objDTOMstUser.Deleted_date = dr["Deleted_date"].ToString();
                        //objDTOMstUser.DeleteIP = dr["DeleteIP"].ToString();
                        //objDTOMstUser.Url_User = dr["Url_User"].ToString();
                        lstMstUser.Add(objDTOMstUser);
                    }
                    con.Close();
                }
                return lstMstUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTOMstUser GetExisting(int code,int resId)
        {
            try
            {
                DTOMstUser objDTOMstUser = new DTOMstUser();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("User_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Edit");
                    cmd.Parameters.AddWithValue("@Id", code);
                    cmd.Parameters.AddWithValue("@Res_Id", resId); 
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        objDTOMstUser.Id = Convert.ToInt32(dr["Id"].ToString());
                        objDTOMstUser.User_Name = dr["User_Name"].ToString();
                        //objDTOMstUser.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        objDTOMstUser.UserType_Id = Convert.ToInt32(dr["UserType_Id"].ToString());
                        objDTOMstUser.Employee_Id = Convert.ToInt32(dr["Employee_Id"].ToString());
                        objDTOMstUser.Password = dr["Password"].ToString();
                    }
                    con.Close();
                }
                return objDTOMstUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
