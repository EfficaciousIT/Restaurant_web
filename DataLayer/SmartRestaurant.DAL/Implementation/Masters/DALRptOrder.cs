using Dapper;
using SmartRestaurant.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SmartRestaurant.DAL
{
    public class DALRptOrder : IRptOrder
    {
        public List<DTORptOrder> GetOrderDtlByDate(string FromDate, string ToDate)
        {
            try
            {
                List<DTORptOrder> lstCnfDashBoard = new List<DTORptOrder>();

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDBConnection"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("rptOrder_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@command", "ViewOrderOnDateWise");
                    cmd.Parameters.AddWithValue("@FromDate", FromDate);
                    cmd.Parameters.AddWithValue("@ToDate", ToDate);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        DTORptOrder objDTORptOrder = new DTORptOrder();                        
                        objDTORptOrder.Order_id = Convert.ToInt32(dr["Order_id"].ToString());
                        if (dr["grandTotal"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.grandTotal = Convert.ToDecimal(dr["grandTotal"].ToString());
                        }
                        if (dr["Table_Name"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Table_Name = dr["Table_Name"].ToString();
                        }
                        if (dr["Total"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Total = Convert.ToDecimal(dr["Total"].ToString());
                        }
                        if (dr["Price"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Price = Convert.ToDecimal(dr["Price"].ToString());
                        }
                        if (dr["Qty"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Qty = Convert.ToInt32(dr["Qty"].ToString());
                        }

                        if (dr["Menu_Name"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Menu_Name = dr["Menu_Name"].ToString();
                        }
                        if (dr["status"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.status = dr["status"].ToString();
                        }
                        if (dr["Employee_Id"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Employee_Id = Convert.ToInt32(dr["Employee_Id"].ToString());
                        }
                        if (dr["Employee_Name"].GetType() != typeof(DBNull))
                        {
                            objDTORptOrder.Employee_Name = dr["Employee_Name"].ToString();
                        }
                        //objDTORptOrder.Date = dr["Date"].ToString();
                        //objDTORptOrder.Res_Id = Convert.ToInt32(dr["Res_Id"].ToString());

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
