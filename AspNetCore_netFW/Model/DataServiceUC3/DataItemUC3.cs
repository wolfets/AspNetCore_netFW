namespace AspNetCore_netFW.Model
{
    public class DataItemUC3
    {
        public string Title
        {
            get;
            private set;
        }


        public DataItemUC3(string title)
        {
            Title = title;
        }


        //private DataItem DIMain
        //{
        //    get; set;
        //}
        //public void setDataItemMain(DataItem diMain)
        //{
        //    DIMain = DIMain;
        //}
        //public DataItem getDataItemMain()
        //{
        //    return DIMain;
        //}
    }
}