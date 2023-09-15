using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Софа";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Софа", res);
        }
    }
}
