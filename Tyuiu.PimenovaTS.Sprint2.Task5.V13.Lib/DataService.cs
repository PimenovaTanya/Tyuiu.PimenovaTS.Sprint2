using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PimenovaTS.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public double FindDateOfNextDay(int g, int m, int n)
        {
            

            switch (n)
            {
                case 31:
                    switch(m)
                    {
                        case 12:
                            n = 1;
                            m = 1;
                            g++;
                            break;
                        default:
                            m++;
                            switch(m)
                            {
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                    n = 1;
                                    break;

                            }
                            break;

                    }
                    break;
                case 29:
                    switch(m)
                    {
                        case 2:
                            n = 1;
                            m = 3;
                            break;
                        default:
                            n = 30;
                            break;
                    }
                    break;
                    
                case 30:
                    switch(m)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            n = 1;
                            m++;
                            break;
                        default:
                            n = 31;
                            break;
                    }
                    break;
                default:
                    n++;
                    break;

            }

            string t = g.ToString();
            string l = m.ToString();
            string q = n.ToString();

            return Double.Parse(t + l + q);
        }
    }
}
