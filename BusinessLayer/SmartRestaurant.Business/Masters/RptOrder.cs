using SmartRestaurant.DAL;
using SmartRestaurant.DTO;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Business
{
    public class RptOrder
    {
        public static IRptOrder _dalRptOrder;

        public static List<RptOrderModel> GetBillNotification(string fromDate, string ToDate)
        {
            try
            {
                _dalRptOrder = new DALRptOrder();
                return fillTableList(_dalRptOrder.GetOrderDtlByDate(fromDate, ToDate));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<RptOrderModel> fillTableList(List<DTORptOrder> _objDtoRptOrder)
        {
            var list = from dtoRptOrder in _objDtoRptOrder
                       select new RptOrderModel()
                       {
                           // Add your Column here

                           Order_id = dtoRptOrder.Order_id,
                           Table_Name = dtoRptOrder.Table_Name!= null ? dtoRptOrder.Table_Name: string.Empty,
                           Res_Id = dtoRptOrder.Res_Id,
                           grandTotal = dtoRptOrder.grandTotal,
                           Menu_Name = dtoRptOrder.Menu_Name != null ? dtoRptOrder.Menu_Name:string.Empty,
                           Qty = dtoRptOrder.Qty,
                           status = dtoRptOrder.status != null ? dtoRptOrder.status : string.Empty,
                           Price = dtoRptOrder.Price,
                           Date = dtoRptOrder.Date != null ? dtoRptOrder.Date:string.Empty,
                           Total = dtoRptOrder.Total,
                           Employee_Id = dtoRptOrder.Employee_Id,
                           Employee_Name = dtoRptOrder.Employee_Name != null ? dtoRptOrder.Employee_Name : string.Empty,

                       };
            return list.AsEnumerable<RptOrderModel>().ToList();
        }
    }
}
