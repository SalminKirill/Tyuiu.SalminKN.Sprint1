using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task5.V0.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 15;
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 58;
            Assert.AreEqual(result, wait);
        }
    }
}
