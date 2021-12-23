using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.DAL
{
    public class ConManager : IDisposable
    {

        //public IDbConnection masterDb = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString);
        //public IDbConnection transactionDb = new SqlConnection(ConfigurationManager.ConnectionStrings["TransactionDBConnection"].ConnectionString);
        //public IDbConnection reportDb = new SqlConnection(ConfigurationManager.ConnectionStrings["ReportDBConnection"].ConnectionString);

        public void Dispose()
        {
            //transactionDb.Dispose();
            //masterDb.Dispose();
            //reportDb.Dispose();
        }
    }
}
