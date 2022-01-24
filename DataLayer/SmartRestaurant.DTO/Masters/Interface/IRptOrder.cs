using System;
using System.Collections.Generic;

namespace SmartRestaurant.DTO
{
    public interface IRptOrder 
    {
        List<DTORptOrder> GetOrderDtlByDate(DateTime FromDate, DateTime ToDate);
    }
}
