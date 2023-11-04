using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint4.Task2.V11.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 7, 7, 8, 8, 2, 6, 3, 3, 3, 2 };
            int wait = 26;
            int res = ds.Calculate(array);
            Assert.AreEqual(res, wait);
        }
    }
}
