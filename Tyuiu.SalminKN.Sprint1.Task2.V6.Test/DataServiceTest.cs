using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task2.V6.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int metr = 120000;
            int res = Convert.ToInt32(ds.ConvertMToKm(metr));
            Assert.AreEqual(120, res);

        }
    }
}
