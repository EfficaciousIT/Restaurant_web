using System;
using System.Collections.Generic;

namespace SmartRestaurant.DTO
{
    public interface IMstEmployee : IMstBase<DTOMstEmployee>
    {
        List<DTOMstEmployee> GetEmployeeAll(int resId);
    }
}
