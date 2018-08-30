using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore_netFW.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
        void Get21(Action<int, Exception> callback);
    }
}
