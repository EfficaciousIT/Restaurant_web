using System.Collections.Generic;

namespace SmartRestaurant.DTO
{
    public interface IMstBase<T> where T :class
    {        
        List<T> GetAll(int resId);
        T GetExisting(int code, int resId);
        int Create(T data);
        //int NextMastCode();
        int Edit(T data);
        int Delete(T data);

        //for approve functionality
        //List<T> GetApprovalPendingList();
        //int Approve(T data);
        //int Approve(string strMstCodeList, string ApprovedBy);
    }
}
