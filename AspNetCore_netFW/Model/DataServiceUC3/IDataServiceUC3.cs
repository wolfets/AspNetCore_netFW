using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore_netFW.Model
{
    public interface IDataServiceUC3
    {
        void GetData(Action<DataItemUC3, DataItem, Exception> callback);

        void SetData(string diTitle, Action<DataItemUC3, Exception> callback);

    }
}
