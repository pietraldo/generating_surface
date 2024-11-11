using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace generating_surface
{
    public class Vertex
    {
        public Vector3 start_point;
        public Vector3 rotated_point;

        public float u;
        public float v;

        public Vector3 N;
        public Vector3 L;
        public Vector3 V;
        public Vector3 R;


        public Point Rotated2DPoint()
        {
            return new Point((int)rotated_point.X, (int)rotated_point.Y);
        }
    }
}
