﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Services {
     class CalculationService {
        /*
         public static double Max(double x, double y) {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y) {
            return x + y;
        }

        public static double Square(double x) {
            return x * x;
        }
        */

        public static void ShowMax(double x, double y) {
            Console.WriteLine((x > y) ? x : y);
        }

        public static void ShowSum(double x, double y) {
            Console.WriteLine(x + y);
        }
    }
}
