using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task5.V5.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double exp = 5;
            double valid = 34.554;
            double res = ds.Calculate(valid);
            Assert.AreEqual(exp, res);
        }
    }
}
