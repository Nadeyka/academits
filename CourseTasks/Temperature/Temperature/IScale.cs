﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public interface IScale
    {
        string ScaleName { get; }
        double ConvertTempToCelsium(double degree);
        double ConvertTempFromCelsium(double degree);
    }
}
