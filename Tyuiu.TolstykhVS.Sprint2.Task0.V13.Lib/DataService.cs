﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolstykhVS.Sprint2.Task0.V13.Lib
{
    public class DataService : ISprint2Task0V13
    {

        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x != y;
            res[2] = x - 1680 > y;
            res[3] = x - 1500 < y;
            res[4] = x  <= y;
            res[5] = x - 12 >= y;
                return res;
        }
    }
}
