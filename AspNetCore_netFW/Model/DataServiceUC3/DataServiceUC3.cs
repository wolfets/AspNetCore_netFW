using MvvmLight1;
using System;

namespace MvvmLight1.Model
{
    public class DataServiceUC3 : IDataServiceUC3
    {
        DataItemUC3 item2 = null;
        public void GetData(Action<DataItemUC3, DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            item2 = new DataItemUC3("DataServiceUC3");
            var itemMain = new DataItem("DataServiceMain créé par UC3");
            callback(item2, itemMain, null);

        }

        public void SetData(string diTitle, Action<DataItemUC3, Exception> callback)
        {
            //var item2 = new DataItemUC3(diTitle);
            callback(item2, null);
            //throw new NotImplementedException();
        }
    }
}