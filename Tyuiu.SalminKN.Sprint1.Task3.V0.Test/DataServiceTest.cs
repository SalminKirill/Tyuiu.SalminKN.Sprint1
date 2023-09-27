using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task3.V0.Lib;

namespace Tyuiu.SalminKN.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 3;
            int b = 4;
            int wait = 12;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}
