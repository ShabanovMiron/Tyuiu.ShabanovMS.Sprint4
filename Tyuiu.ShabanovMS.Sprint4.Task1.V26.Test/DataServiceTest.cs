using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint4.Task1.V26.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };
            int wait = 1323;
            int res = ds.Calculate(array);
            Assert.AreEqual(res, wait);
        }
    }
}
