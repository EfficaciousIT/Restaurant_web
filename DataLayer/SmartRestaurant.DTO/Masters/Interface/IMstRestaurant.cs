using System;

namespace SmartRestaurant.DTO
{
    public interface IMstRestaurant: IMstBase<DTOMstRestaurant>
    {
        int RegisterNewRestaurant(DTOMstRestaurant data);
    }
}
