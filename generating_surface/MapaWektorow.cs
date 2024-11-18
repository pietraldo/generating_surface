using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace generating_surface
{
    public class MapaWektorow
    {
        public static Vector3 S(double u, double v)
        {
            double z = Math.Sin(Math.Pow(u, 2) / 9 + Math.Pow(v, 2) / 9);
            return new Vector3((float)u, (float)v, (float)z);
        }

        public static Vector3 CalculatePu(double u, double v)
        {
            return new Vector3(1, 0, (float)(Math.Cos(u * u / 9 + v * v / 9) * 2 * u / 9));
        }

        public static Vector3 CalculatePv(double u, double v)
        {
            return new Vector3(0, 1, (float)(Math.Cos(u * u / 9 + v * v / 9) * 2 * v / 9));
        }


        public static Vector3 NormalVector(double u, double v)
        {
            Vector3 Pu = CalculatePu(u, v);
            Vector3 Pv = CalculatePv(u, v);

            Vector3 N = new Vector3();
            N.X = Pu.Y * Pv.Z - Pu.Z * Pv.Y;
            N.Y = Pu.Z * Pv.X - Pu.X * Pv.Z;
            N.Z = Pu.X * Pv.Y - Pu.Y * Pv.X;
            return Vector3.Normalize(N);
        }
        public static Color CalculateColor(double u, double v)
        {
            Vector3 N = NormalVector(u, v);

            int red = (int)(N.X * 128 + 128);
            int green = (int)(N.Y * 128 + 128);
            int blue = (int)(N.Z * 128 + 128);

            red = Math.Clamp(red, 0, 255);
            green = Math.Clamp(green, 0, 255);
            blue = Math.Clamp(blue, 0, 255);

            return Color.FromArgb(red, green, blue);
        }
    }
}
