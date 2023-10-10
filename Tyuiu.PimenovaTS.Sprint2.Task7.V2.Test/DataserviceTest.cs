using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint2.Task7.V2.Lib;

namespace Tyuiu.PimenovaTS.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.2;
            double y = -0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}
