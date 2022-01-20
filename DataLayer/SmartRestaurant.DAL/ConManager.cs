using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SmartRestaurant.DAL
{
    public class ConManager : IDisposable
    {

        public IDbConnection masterDb = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString);
        //public IDbConnection transactionDb = new SqlConnection(ConfigurationManager.ConnectionStrings["TransactionDBConnection"].ConnectionString);
        //public IDbConnection reportDb = new SqlConnection(ConfigurationManager.ConnectionStrings["ReportDBConnection"].ConnectionString);

        public void Dispose()
        {
            masterDb.Dispose();
            //transactionDb.Dispose();            
            //reportDb.Dispose();
        }
    }
}
