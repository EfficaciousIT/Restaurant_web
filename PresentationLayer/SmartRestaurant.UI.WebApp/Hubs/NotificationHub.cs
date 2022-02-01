using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SmartRestaurant.Business;
using SmartRestaurant.Model;

namespace SmartRestaurant.Hubs
{
    public class NotificationHub : Hub
    {
        private static string conString =ConfigurationManager.ConnectionStrings["MasterDBConnection"].ToString();
        public void Hello()
        {
            Clients.All.hello();
        }

        [HubMethodName("sendMessages")]
        public static void SendMessages()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            context.Clients.All.updateMessages();
        }


        //DashBoardModel dashBoardModel = new DashBoardModel();

        //public async Task<DashBoardModel> SendBillNotification()
        //{
        //    try
        //    {
        //       // List<DTOCnfDashBoard> lstCnfDashBoard = new List<DTOCnfDashBoard>();

        //        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
        //        {
        //            SqlCommand cmd = new SqlCommand("Notification_SP", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@command", "BillNotification");
        //            cmd.Parameters.AddWithValue("@Res_id", 1);
        //            SqlDependency dependency = new SqlDependency(cmd);
        //            dependency.OnChange += Dependency_OnChange;
        //            if (con.State == ConnectionState.Closed)
        //            {
        //                con.Open();
        //            }
        //            //con.Open();
        //            SqlDataReader dr = cmd.ExecuteReader();

        //            while (dr.Read())
        //            {
        //                DashBoardModel objCnfDashBoard = new DashBoardModel();

        //                objCnfDashBoard.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
        //                objCnfDashBoard.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
        //                objCnfDashBoard.Table_Name = dr["Table_Name"].ToString();
        //                objCnfDashBoard.Total = Convert.ToDecimal(dr["Total"]);

        //                dashBoardModel.BillDetail.Add(objCnfDashBoard);
        //            }
        //            con.Close();
        //        }
        //        IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
        //        return await context.Clients.All.RecieveNotification(dashBoardModel);
        //        //return dashBoardModel;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    if (e.Type == SqlNotificationType.Change)
        //    {
        //        NotificationHub nHub = new NotificationHub();
        //        nHub.SendBillNotification();
        //    }
        //}
    }
}