using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint4.Task6.V18.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var mas = new string[] { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            var wait = new string[] { "Попугай", "Черепаха" };
            var res = ds.Calculate(mas);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
