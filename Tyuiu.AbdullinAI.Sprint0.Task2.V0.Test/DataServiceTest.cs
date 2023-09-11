using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AbdullinAI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            /*Область создания методов тестирования, методов из библиотеки*/
            var name = "Артур";
            var res = DataService.GetMessage(name);
            /*Вызываем класс Assert и метод AreEqual*/
            Assert.AreEqual("Привет..., Артур", res);
        }
    }
}
