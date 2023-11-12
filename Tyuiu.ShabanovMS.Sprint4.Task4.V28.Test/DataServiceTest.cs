﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint4.Task4.V28.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = {
                { 4, 4, 7, 8, 9 },
                { 9, 5, 9, 7, 8 },
                { 7, 4, 9, 4, 6 },
                { 4, 4, 7, 4, 4 },
                { 4, 5, 8, 6, 7 } };

            int[,] wait = {
                      { 1, 1, 7, 1, 9 },
                      { 9, 5, 9, 7, 1 },
                      { 7, 1, 9, 1, 1 },
                      { 1, 1, 7, 1, 1 },
                      { 1, 5, 1, 1, 7 } };
            int [,] res = ds.Calculate(array);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
