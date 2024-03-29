﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolstykhVS.Sprint2.Task4.V4.Lib
{
    public class DataService : ISprint2Task4V4
    {
        public double Calculate(double x, double y)
        {
            double z = (x + 2 < y) ? (Math.Sin(x) + 2 * y) : (Math.Cos(y) + 2 * x * y);
            return z;
        }
    }
}
