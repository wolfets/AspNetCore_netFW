using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmLight1.Model;

//https://msdn.microsoft.com/fr-fr/library/ms182532.aspx#BKMK_Create_a_unit_test_project
//https://docs.microsoft.com/fr-fr/dotnet/core/testing/unit-testing-with-mstest
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ctrl = new DataService();
            Assert.IsFalse(ctrl == null, "1 should not be prime");
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ctrl = new DataService();
            ctrl.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        Assert.IsTrue(false, "1 should not be prime");
                    }
                    Assert.IsTrue(true, "1 should not be prime");
                });
            Assert.IsFalse(ctrl == null, "1 should not be prime");
        }
    }
}
