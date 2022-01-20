using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Business
{
    public class SelectedNVList
    {
    }
    public class RunTime<I, T> : IRunTime
    where I : class, IStoreData
    where T : class, new()
    {
        private I _Interface;

        public RunTime()
        {
            _Interface = new T() as I;
        }

        public I Interface
        {
            get { return _Interface; }
        }

        public virtual int StoreObject()
        {
            return _Interface.StoreData();
        }
    }

    //public class MyCOMCoClass : MyCOMInterface
    //{
    //    public int StoreData()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public interface MyCOMInterface : IStoreData
    //{

    //}

    public interface IStoreData
    {
        int StoreData();
    }

    public interface IRunTime
    {
        int StoreObject();
    }
}
