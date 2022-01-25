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
    public class DALCnfDashBoard : ICnfDashBoard
    {
        public List<DTOCnfDashBoard> GetBillNotification(int ResId)
        {
            try
            {
                List<DTOCnfDashBoard> lstCnfDashBoard = new List<DTOCnfDashBoard>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Notification_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "BillNotification");
                    cmd.Parameters.AddWithValue("@Res_id", ResId);
                    //SqlDependency dependency = new SqlDependency(cmd);
                    //dependency.OnChange += Dependency_OnChange;
                    //if (con.State == ConnectionState.Closed)
                    //{
                    //    con.Open();
                    //}
                      con.Open();                      
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOCnfDashBoard objDTOCnfDashBoard = new DTOCnfDashBoard();

                        objDTOCnfDashBoard.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        objDTOCnfDashBoard.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
                        objDTOCnfDashBoard.Table_Name = dr["Table_Name"].ToString();
                        objDTOCnfDashBoard.Total = Convert.ToDecimal(dr["Total"]);

                        lstCnfDashBoard.Add(objDTOCnfDashBoard);
                    }
                    con.Close();
                }
                return lstCnfDashBoard;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    if (e.Type == SqlNotificationType.Change)
        //    {
        //        NotificationHub
        //    }
        //}

        public List<DTOCnfDashBoard> GetTakeAwayNotification(int ResId)
        {
            try
            {
                List<DTOCnfDashBoard> lstCnfDashBoard = new List<DTOCnfDashBoard>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Notification_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "TakeAwayNotification");
                    cmd.Parameters.AddWithValue("@Res_id", ResId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOCnfDashBoard objDTOCnfDashBoard = new DTOCnfDashBoard();

                        objDTOCnfDashBoard.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        objDTOCnfDashBoard.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
                        objDTOCnfDashBoard.First_Name = dr["First_Name"].ToString();
                        objDTOCnfDashBoard.Mobile_No = dr["Mobile_No"].ToString();
                        objDTOCnfDashBoard.Address_1 = dr["Address_1"].ToString();
                        objDTOCnfDashBoard.Address_2 = dr["Address_2"].ToString();
                        objDTOCnfDashBoard.Total = Convert.ToDecimal(dr["Total"].ToString());

                        lstCnfDashBoard.Add(objDTOCnfDashBoard);
                    }
                    con.Close();
                }
                return lstCnfDashBoard;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DTOCnfDashBoard> GetDispatchNotification(int ResId)
        {
            try
            {
                List<DTOCnfDashBoard> lstCnfDashBoard = new List<DTOCnfDashBoard>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Notification_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "DispatchNotification");
                    cmd.Parameters.AddWithValue("@Res_id", ResId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOCnfDashBoard objDTOCnfDashBoard = new DTOCnfDashBoard();

                        objDTOCnfDashBoard.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        objDTOCnfDashBoard.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
                        objDTOCnfDashBoard.First_Name = dr["First_Name"].ToString();
                        objDTOCnfDashBoard.Mobile_No = dr["Mobile_No"].ToString();
                        objDTOCnfDashBoard.Address_1 = dr["Address_1"].ToString();
                        objDTOCnfDashBoard.Address_2 = dr["Address_2"].ToString();
                        objDTOCnfDashBoard.Total = Convert.ToDecimal(dr["Total"].ToString());

                        lstCnfDashBoard.Add(objDTOCnfDashBoard);
                    }
                    con.Close();
                }
                return lstCnfDashBoard;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DTOCnfDashBoard> GetOrderNotification(int ResId)
        {
            try
            {
                List<DTOCnfDashBoard> lstCnfDashBoard = new List<DTOCnfDashBoard>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Notification_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "OrderNotification");
                    cmd.Parameters.AddWithValue("@Res_id", ResId);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTOCnfDashBoard objDTOCnfDashBoard = new DTOCnfDashBoard();

                        objDTOCnfDashBoard.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                        objDTOCnfDashBoard.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
                        objDTOCnfDashBoard.Table_Name = dr["Table_Name"].ToString();
                        objDTOCnfDashBoard.Total = Convert.ToDecimal(dr["Total"].ToString());

                        lstCnfDashBoard.Add(objDTOCnfDashBoard);
                    }
                    con.Close();
                }
                return lstCnfDashBoard;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
