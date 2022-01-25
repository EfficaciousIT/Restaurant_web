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
    public class DashBoard
    {
        public static ICnfDashBoard _dalCnfDashBoard;

        public static List<DashBoardModel> GetBillNotification(int resId)
        {
            try
            {
                _dalCnfDashBoard = new DALCnfDashBoard();
                return fillTableList(_dalCnfDashBoard.GetBillNotification(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        public static List<DashBoardModel> GetTakeAwayNotification(int resId)
        {
            try
            {
                _dalCnfDashBoard = new DALCnfDashBoard();
                return fillTableList(_dalCnfDashBoard.GetTakeAwayNotification(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        public static List<DashBoardModel> GetDispatchNotification(int resId)
        {
            try
            {
                _dalCnfDashBoard = new DALCnfDashBoard();
                return fillTableList(_dalCnfDashBoard.GetDispatchNotification(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        public static List<DashBoardModel> GetOrderNotification(int resId)
        {
            try
            {
                _dalCnfDashBoard = new DALCnfDashBoard();
                return fillTableList(_dalCnfDashBoard.GetOrderNotification(resId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }
        

        private static List<DashBoardModel> fillTableList(List<DTOCnfDashBoard> _objDtoCnfDashBoard)
        {
            var list = from dtoDashBoard in _objDtoCnfDashBoard
                       select new DashBoardModel()
                       {
                           // Add your Column here

                           Order_id = dtoDashBoard.Order_id,
                           Table_Name = dtoDashBoard.Table_Name,
                           Res_Id = dtoDashBoard.Res_Id,
                           Address_1 = dtoDashBoard.Address_1,
                           Address_2 = dtoDashBoard.Address_2,
                           First_Name = dtoDashBoard.First_Name,
                           Total = dtoDashBoard.Total

                       };
            return list.AsEnumerable<DashBoardModel>().ToList();
        }
    }
}
