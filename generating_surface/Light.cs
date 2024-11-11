using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generating_surface
{
    public class Light
    {
        public Color IL;
        public Color IO;
        public double kd;
        public double ks;
        public int m;

        public Light(Color IL, Color IO, double kd, double ks, int m)
        {
            this.IL = IL;
            this.IO = IO;
            this.kd = kd;
            this.ks = ks;
            this.m = m;
        }
    }
}
