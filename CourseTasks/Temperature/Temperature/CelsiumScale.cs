﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class CelsiumScale : ITemperatureConverter
    {
        public double ConvertTempToCelsium(double degree)
        {
            return degree;
        }

        public double ConvertTempFromCelsium(double degree)
        {
            return degree;
        }
    }
}