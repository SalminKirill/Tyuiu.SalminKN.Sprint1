﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint1.Task2.V0.Lib;

namespace Tyuiu.SalminKN.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            Assert.AreEqual(4, res);
        }
    }
}
