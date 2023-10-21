﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MorozAD.Sprint3.Task3.V26.Lib
{
    public class DataService : ISprint3Task3V26
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char chr in value)
            {
                if(chr == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
