using System;
using System.Collections.Generic;

namespace SmartRestaurant.DTO
{
    public interface ICnfDashBoard 
    {
        List<DTOCnfDashBoard> GetBillNotification(int ResId);
        List<DTOCnfDashBoard> GetTakeAwayNotification(int ResId);
        List<DTOCnfDashBoard> GetDispatchNotification(int ResId);
        List<DTOCnfDashBoard> GetOrderNotification(int ResId);
    }
}
