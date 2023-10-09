using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint2.Task6.V12.Lib;

namespace Tyuiu.PimenovaTS.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 23;
            int m = 9;
            int n = 3;

            double res = ds.FindDateOfPreviousDay(g, m, n);
            string w = "2392";


            Assert.AreEqual(Convert.ToDouble(w), res);
        }
    }
}
