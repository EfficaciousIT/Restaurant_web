using System;
using System.Collections.Generic;

namespace SmartRestaurant.DTO
{
    public interface IRptAttendence 
    {
        List<DTORptAttendence> GetEmpAttendence(int ResId);
    }
}
