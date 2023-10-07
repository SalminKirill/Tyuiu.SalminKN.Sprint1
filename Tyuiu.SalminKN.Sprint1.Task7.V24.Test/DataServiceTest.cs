using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task7.V24.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task7.V24.Test
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
            double res = Math.Round(ds.Calculate(x, y), 3);
            double wait = 1.101;
            Assert.AreEqual(wait, res);
        }
    }
}
