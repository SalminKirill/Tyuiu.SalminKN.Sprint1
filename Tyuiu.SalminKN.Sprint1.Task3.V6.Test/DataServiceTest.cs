﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task3.V6.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            double wait = 74.04;
            double res = ds.TravelCost(distance, gasFlow, gasPrice);

            Assert.AreEqual(wait, res);
        }
    }
}
