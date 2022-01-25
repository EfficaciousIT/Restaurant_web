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
        readonly string _connString =
        ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public IEnumerable<DashBoardModel> GetAllDashBoardModel()
        {
            var DashBoardModel = new List<DashBoardModel>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var command = new SqlCommand(@"SELECT [MessageID], 
                [Message], [EmptyMessage], [Date] FROM [dbo].[DashBoardModel]", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DashBoardModel.Add(item: new DashBoardModel
                        {
                            Order_id = 1,
                        //    Message = (string)reader["Message"],
                        //    EmptyMessage = reader["EmptyMessage"] != DBNull.Value ?
                        //(string)reader["EmptyMessage"] : "",
                        //    MessageDate = Convert.ToDateTime(reader["Date"])
                        });
                    }
                }
            }
            return DashBoardModel;
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