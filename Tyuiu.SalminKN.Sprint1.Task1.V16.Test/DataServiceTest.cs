using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SalminKN.Sprint1.Task1.V16.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = Convert.ToInt32(ds.Calculate(1, 1, 1));
            Assert.AreEqual(7, res);
        }
    }
}
