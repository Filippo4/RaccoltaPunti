using System;
using System.Collections.Generic;
using System.Text;

namespace RaccoltaPunti
{
    class Punto2 : Punto1
    {
        public double z { get; set; }
        public Punto2(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }
    }
}
