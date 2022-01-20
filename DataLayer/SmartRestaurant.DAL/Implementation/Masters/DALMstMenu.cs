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
    public class DALMstMenu: IMstMenu
    {
        public int Create(DTOMstMenu data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Menu_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Insert");
                    cmd.Parameters.AddWithValue("@Menu_Name", data.Menu_Name);
                    cmd.Parameters.AddWithValue("@Res_id", data.Res_id);
                    cmd.Parameters.AddWithValue("@Menu_Id", data.Menu_Id);
                    cmd.Parameters.AddWithValue("@Menu_Type", data.Menu_Type);
                    cmd.Parameters.AddWithValue("@Price", data.Price);                    
                    cmd.Parameters.AddWithValue("@Cat_Id", data.Cat_Id);
                    cmd.Parameters.AddWithValue("@IntInserted_by", data.IntInserted_by);
                    cmd.Parameters.AddWithValue("@InseretIP", data.InseretIP);
                   

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

        public int Delete(DTOMstMenu data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Menu_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Delete");                                     
                    cmd.Parameters.AddWithValue("@Menu_Id", data.Menu_Id);
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

        public int Edit(DTOMstMenu data)
        {
            try
            {
                int result = 0;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Menu_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Update");
                    cmd.Parameters.AddWithValue("@Cat_Id", data.Cat_Id);
                    cmd.Parameters.AddWithValue("@Menu_Name", data.Menu_Name);
                    cmd.Parameters.AddWithValue("@Menu_Id", data.Menu_Id);
                    cmd.Parameters.AddWithValue("@Menu_Type", data.Menu_Type);
                    cmd.Parameters.AddWithValue("@Price", data.Price);                    
                    cmd.Parameters.AddWithValue("@Res_id", data.Res_id);
                    cmd.Parameters.AddWithValue("@IntUpdate_by", data.IntUpdate_by);
                    cmd.Parameters.AddWithValue("@UpdateIP", data.UpdateIP);
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

        public List<DTOMstMenu> GetAll(int resId)
        {
            try
            {
                List<DTOMstMenu> lstMstMenu = new List<DTOMstMenu>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Menu_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Select");
                    cmd.Parameters.AddWithValue("@Res_id", resId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOMstMenu objDTOMstMenu = new DTOMstMenu();

                        objDTOMstMenu.Menu_Id = Convert.ToInt32(dr["Menu_Id"].ToString());
                        objDTOMstMenu.Menu_Type = dr["Menu_Type"].ToString();
                        objDTOMstMenu.Menu_Name = dr["Menu_Name"].ToString();
                        objDTOMstMenu.Price = Convert.ToInt32(dr["Price"].ToString());
                        objDTOMstMenu.Res_id = Convert.ToInt32(dr["Res_id"].ToString());
                        objDTOMstMenu.Cat_Name = dr["Cat_Name"].ToString();
                        //objDTOMstMenu.InseretIP = dr["InseretIP"].ToString();
                        //objDTOMstMenu.IntUpdate_by = dr["IntUpdate_by"].ToString();
                        //objDTOMstMenu.Updated_date = dr["Updated_date"].ToString();
                        //objDTOMstMenu.UpdateIP = dr["UpdateIP"].ToString();
                        //objDTOMstMenu.IntDelete_by = dr["IntDelete_by"].ToString();
                        //objDTOMstMenu.Deleted_date = dr["Deleted_date"].ToString();
                        //objDTOMstMenu.DeleteIP = dr["DeleteIP"].ToString();
                        //objDTOMstMenu.Url_Menu = dr["Url_Menu"].ToString();
                        lstMstMenu.Add(objDTOMstMenu);
                    }
                    con.Close();
                }
                return lstMstMenu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTOMstMenu GetExisting(int code,int resId)
        {
            try
            {
                DTOMstMenu objDTOMstMenu = new DTOMstMenu();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Menu_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "Edit");
                    cmd.Parameters.AddWithValue("@Res_Id", resId);
                    cmd.Parameters.AddWithValue("@Menu_Id", code);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        objDTOMstMenu.Menu_Id = Convert.ToInt32(dr["Menu_Id"].ToString());
                        objDTOMstMenu.Menu_Type = dr["Menu_Type"].ToString();
                        objDTOMstMenu.Menu_Name = dr["Menu_Name"].ToString();
                        objDTOMstMenu.Price = Convert.ToInt32(dr["Price"].ToString());                        
                        objDTOMstMenu.Cat_Id = Convert.ToInt32(dr["Cat_Id"].ToString());
                    }
                    con.Close();
                }
                return objDTOMstMenu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
