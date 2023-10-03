using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PimenovaTS.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //  a = 247, b = 654, c = 671, d = 671
            bool[] res = new bool[6];

            res[0] = (a > b) | (c == d);
            res[1] = (a < b) & (c != d);
            res[2] = (c > b) || (a == d);
            res[3] = (a < b) && (c < d);
            res[4] = !res[1];
            res[5] = (a < b) ^ (c == d);

            return res;
        }
    }
}
