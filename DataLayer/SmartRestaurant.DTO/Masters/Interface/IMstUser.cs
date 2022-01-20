using System;

namespace SmartRestaurant.DTO
{
    public interface IMstUser : IMstBase<DTOMstUser>
    {
        DTOMstUser CheckLogin(DTOMstUser data);
    }
}
