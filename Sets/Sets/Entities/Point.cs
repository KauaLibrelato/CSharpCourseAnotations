using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets.Entities {
    internal struct Point {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y) : this() {
            X = x;
            Y = y;
        }

        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }

    }
}
