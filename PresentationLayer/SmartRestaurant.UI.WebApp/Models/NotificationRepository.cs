using SmartRestaurant.Hubs;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmartRestaurant.UI.WebApp.Models
{
    public class NotificationRepository
    {
        readonly string _connString =ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString;

        public DashBoardModel GetAllDashBoardModel()
        {
            DashBoardModel objreturn = new DashBoardModel();
            List<DashBoardModel> DashBoardModel = new List<DashBoardModel>();
            
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Notification_SP", con);
                cmd.Notification = null;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@command", "BillNotification");
                cmd.Parameters.AddWithValue("@Res_id", 1);
                SqlDependency dependency = new SqlDependency(cmd);
                dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DashBoardModel objDTOCnfDashBoard = new DashBoardModel();

                    objDTOCnfDashBoard.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
                    objDTOCnfDashBoard.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
                    objDTOCnfDashBoard.Table_Name = dr["Table_Name"].ToString();
                    objDTOCnfDashBoard.Total = Convert.ToDecimal(dr["Total"]);

                    DashBoardModel.Add(objDTOCnfDashBoard);
                    
                }
                con.Close();
            }
            objreturn.BillDetail = DashBoardModel;
            return objreturn;
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                NotificationHub.SendMessages();
            }
        }
    }
}