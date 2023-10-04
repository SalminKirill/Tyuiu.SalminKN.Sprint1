using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.SalminKN.Sprint1.TaskPreview.V21.Lib;
namespace Tyuiu.SalminKN.Sprint1.TaskPreview.V21.Class
{
    [TestClass]
    public class DataServiceTest 
    {
        public DataServiceTest()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2.000, 2.000);
            Assert.AreEqual(res, -2.669);
        }
    }
}
