using System;

namespace AspNetCore_netFW.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem();/// "Welcome to MVVM Light");
            item.Title = "Welcome to MVVM Light";
            callback(item, null);
        }

        public void Get21(Action<int, Exception> callback)
        {
            callback(21, null);
        }

    }
}