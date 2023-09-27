using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task4.V6.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = -5.872;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
