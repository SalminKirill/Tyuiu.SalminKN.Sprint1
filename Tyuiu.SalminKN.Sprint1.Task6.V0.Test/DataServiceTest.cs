using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task6.V0.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strTest);
            string wait = "123";
            Assert.AreEqual(wait, res);
        }
    }
}
