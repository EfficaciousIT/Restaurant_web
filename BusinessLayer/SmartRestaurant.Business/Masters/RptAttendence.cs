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
    public class RptAttendence
    {
        public static IRptAttendence _dalRptAttendence;

        public static List<RptAttendenceModel> GetBillNotification(int ResId)
        {
            try
            {
                _dalRptAttendence = new DALRptAttendence();
                return fillTableList(_dalRptAttendence.GetEmpAttendence(ResId));
            }
            catch
            {
                throw new Exception("Request Failed");
            }
        }

        private static List<RptAttendenceModel> fillTableList(List<DTORptAttendence> _objDtoRptAttendence)
        {
            var list = from dtoRptAttendence in _objDtoRptAttendence
                       select new RptAttendenceModel()
                       {
                           // Add your Column here
                           Employee_Id = dtoRptAttendence.Employee_Id,
                           Res_Id = dtoRptAttendence.Res_Id,
                           Employee_Name = dtoRptAttendence.Employee_Name != null ? dtoRptAttendence.Employee_Name : string.Empty,
                           Date = dtoRptAttendence.Date != null ? dtoRptAttendence.Date : string.Empty,
                           Intime = dtoRptAttendence.Intime != null ? dtoRptAttendence.Intime : string.Empty,                           
                           Outtime = dtoRptAttendence.Outtime != null ? dtoRptAttendence.Outtime : string.Empty,                           
                           WorkingHRS = dtoRptAttendence.WorkingHRS != null ? dtoRptAttendence.WorkingHRS : string.Empty,
                       };
            return list.AsEnumerable<RptAttendenceModel>().ToList();
        }
    }
}
