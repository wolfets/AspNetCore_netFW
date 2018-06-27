using System;

namespace MvvmLight1.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem();/// "Welcome to MVVM Light");
            item.Title = "Welcome to MVVM Light____";
            callback(item, null);
        }
    }
}