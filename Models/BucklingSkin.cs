﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFrame.Models
{
    class BucklingSkin
    {

        public static double Buckling(double k, double e, double b, double delta)
        {
            double critical =  k * e / (b / delta * b / delta);
            return critical;
        }
    }
}
