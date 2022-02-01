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
    public class DALRptAttendence : IRptAttendence
    {
        public List<DTORptAttendence> GetEmpAttendence(int resId)
        {
            try
            {
                List<DTORptAttendence> lstCnfDashBoard = new List<DTORptAttendence>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("rptAttendence_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "AttendenceGrid");
                    cmd.Parameters.AddWithValue("@Res_Id", resId);
                    
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTORptAttendence objDTORptOrder = new DTORptAttendence();
                        objDTORptOrder.Employee_Id = Convert.ToInt32(dr["Employee_Id"].ToString());
                        if (dr["Employee_Name"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Employee_Name = dr["Employee_Name"].ToString();
                        }
                        if (dr["Intime"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Intime = dr["Intime"].ToString();
                        }
                        if (dr["Outtime"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Outtime = dr["Outtime"].ToString();
                        }
                        if (dr["Date"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Date = dr["Date"].ToString();
                        }
                        if (dr["WorkingHRS"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.WorkingHRS = dr["WorkingHRS"].ToString();
                        }
                        lstCnfDashBoard.Add(objDTORptOrder);
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
