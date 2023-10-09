using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PimenovaTS.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public double FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1:
                    m = 12;
                    g -= 1;
                    break;
                default:
                    m -= 1;
                    break;
            }

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (n == 1)
                    {
                        n = 31;
                    }
                    else
                    {
                        n -= 1;
                    }
                    break;
                case 2:
                    if (n == 1)
                    {
                        n = 29;
                    }
                    else
                    {
                        n -= 1;
                    }
                    break;
                default:
                    if (n == 1)
                    {
                        n = 30;
                    }
                    else
                    {
                        n -= 1;
                    }
                    break;
            }
            string t = g.ToString();
            string v = m.ToString();
            string h = n.ToString();
            return double.Parse(t + v + h);
        }
    }
}
