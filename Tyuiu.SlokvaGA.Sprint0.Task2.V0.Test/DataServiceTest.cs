using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SlokvaGA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SlokvaGA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTestBase
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Григорий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Григорий", res);
        }
    }
}
