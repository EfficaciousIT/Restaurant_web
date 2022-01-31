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
    public class MessagesRepository
    {
        readonly string _connString = ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString;

        //public IEnumerable<DashBoardModel> GetAllDashBoardModel()
        //{
        //    var DashBoardModel = new List<DashBoardModel>();

        //    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("Notification_SP", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@command", "BillNotification");
        //        cmd.Parameters.AddWithValue("@Res_id", 1);
        //        SqlDependency dependency = new SqlDependency(cmd);
        //        dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //        }
        //        //con.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            DashBoardModel objDTOCnfDashBoard = new DashBoardModel();

        //            objDTOCnfDashBoard.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());
        //            objDTOCnfDashBoard.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
        //            objDTOCnfDashBoard.Table_Name = dr["Table_Name"].ToString();
        //            objDTOCnfDashBoard.Total = Convert.ToDecimal(dr["Total"]);

        //            DashBoardModel.Add(objDTOCnfDashBoard);
        //        }
        //        con.Close();
        //    }

        //    return DashBoardModel;
        //}
        //readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<Messages> GetAllMessages()
        {

            var messages = new List<Messages>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var command = new SqlCommand(@"SELECT [MessageID], [Message], [EmptyMessage], [Date] FROM [dbo].[Messages] where 1 = @temp", connection))
                {
                    command.Parameters.AddWithValue("@temp",1);
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        messages.Add(item: new Messages { MessageID = (int)reader["MessageID"], Message = (string)reader["Message"], EmptyMessage = reader["EmptyMessage"] != DBNull.Value ? (string)reader["EmptyMessage"] : "" });
                    }
                }

            }
            return messages;
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.SendMessages();
                NotificationHub.SendMessages();
            }
        }
    }
}