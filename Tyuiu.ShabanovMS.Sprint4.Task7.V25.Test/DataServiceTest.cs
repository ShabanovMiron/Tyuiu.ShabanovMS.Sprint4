﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint4.Task7.V25.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 4;
            int colums = 3;
            int[,] matrix = new int[rows, colums];
            string str = "348561792486";
            int res = ds.Calculate(rows, colums, str);
            int wait = 38;
            Assert.AreEqual(res, wait);
        }
    }
}
