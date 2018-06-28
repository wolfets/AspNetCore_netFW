using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmLight1.Model;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

//https://msdn.microsoft.com/fr-fr/library/ms182532.aspx#BKMK_Create_a_unit_test_project
//https://docs.microsoft.com/fr-fr/dotnet/core/testing/unit-testing-with-mstest

//https://cdn.ttgtmedia.com/digitalguide/images/Misc/professionalvsts_ch14.pdf

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DataService()
        {
            DataService ds = new DataService();
            Assert.IsFalse(ds == null, "ne devrait pas être null");
            Debug.WriteLine("------------------>>>>>" + DateTime.Now.TimeOfDay.ToString());
        }

        [TestMethod]
        public void DataService_Title()
        {
            DataService ctrl = new DataService();
            ctrl.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        Assert.IsTrue(false, $"{error}");
                    }
                    Assert.IsTrue(item.Title == "Welcome to MVVM Light", "Devrait être : 'Welcome to MVVM Light'");
                });
            //Assert.IsFalse(ctrl != null, "1 should not be prime");
        }


        [TestMethod]
        public void DataService_21()
        {
            const int EXPECTED = 21;

            DataService ctrl = new DataService();
            ctrl.Get21(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        Assert.IsTrue(false, $"{error}");
                    }
                Assert.AreEqual(item, EXPECTED);//, $" {item} Devrait être : 21");
                });
            //Assert.IsFalse(ctrl != null, "1 should not be prime");
        }

        [TestMethod]
        public void loadXML()
        {
            //Arrange
            //string filePath = @"C:\Users\STD\Documents\GitHub\AspNetCore_netFW\UnitTestProject1\UnitTest1.xml";
            string filePath = Path.Combine("", @"UnitTest1.xml.xml");

            //Act
            XDocument document = XDocument.Load(filePath);

            //Assert
            Assert.IsTrue(document.Elements() != null);
            Debug.WriteLine(DateTime.Now.TimeOfDay.ToString());
        }

        //https://mikaelkrief.wordpress.com/2011/11/25/c-les-tests-unitaires-part-4-et-fin-les-tests-unitaire-et-la-base-de-donnees/
        // tests base de données à faire

    }
}
