using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint2.Task5.V13.Lib;

namespace Tyuiu.PimenovaTS.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int g = 23;
            int m = 9;
            int n = 1;

            double res = ds.FindDateOfNextDay(g, m, n);
            string w = "2392";


            Assert.AreEqual(Convert.ToDouble(w), res);


        }
    }
}
