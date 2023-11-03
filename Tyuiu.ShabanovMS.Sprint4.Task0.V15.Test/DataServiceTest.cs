using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint4.Task0.V15.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMulti()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int wait = 138915;
            int res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(res, wait);
        }
    }
}
