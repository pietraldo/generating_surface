using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace generating_surface
{
    internal static class FillingTriangle
    {
       

        public static Vector3 CalculatePu(float u, float v, BezierSurface surface)
        {
            Vector3 Pu = new Vector3();

            int n = BezierSurface.size;
            int m = n;


            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    float bersteinU = (float)BezierSurface.Bernstein(u, i, n - 2);
                    float bersteinV = (float)BezierSurface.Bernstein(v, j, m - 1);
                    Pu.X += (surface.rotated_points[i + 1, j].X - surface.rotated_points[i, j].X) * bersteinU * bersteinV;
                    Pu.Y += (surface.rotated_points[i + 1, j].Y - surface.rotated_points[i, j].Y) * bersteinU * bersteinV;
                    Pu.Z += (surface.rotated_points[i + 1, j].Z - surface.rotated_points[i, j].Z) * bersteinU * bersteinV;
                }
            }

            Pu.X *= n;
            Pu.Y *= n;
            Pu.Z *= n;

            return Pu;
        }

        public static Vector3 CalculatePv(float u, float v, BezierSurface surface)
        {
            Vector3 Pv = new Vector3();

            int n = BezierSurface.size;
            int m = n;


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    float bersteinU = (float)BezierSurface.Bernstein(u, i, n - 1);
                    float bersteinV = (float)BezierSurface.Bernstein(v, j, m - 2);
                    Pv.X += (surface.rotated_points[i, j + 1].X - surface.rotated_points[i, j].X) * bersteinU * bersteinV;
                    Pv.Y += (surface.rotated_points[i, j + 1].Y - surface.rotated_points[i, j].Y) * bersteinU * bersteinV;
                    Pv.Z += (surface.rotated_points[i, j + 1].Z - surface.rotated_points[i, j].Z) * bersteinU * bersteinV;
                }
            }

            Pv.X *= m;
            Pv.Y *= m;
            Pv.Z *= m;

            return Pv;
        }

        public static Vector3 CalculateN(float u, float v, BezierSurface surface)
        {
            Vector3 Pu = CalculatePu(u, v, surface);
            Vector3 Pv = CalculatePv(u, v, surface);

            Vector3 N = new Vector3();
            N.X = Pu.Y * Pv.Z - Pu.Z * Pv.Y;
            N.Y = Pu.Z * Pv.X - Pu.X * Pv.Z;
            N.Z = Pu.X * Pv.Y - Pu.Y * Pv.X;
            return Vector3.Normalize(N);
        }

        public static Vector3 CalculateR(Vector3 N, Vector3 L)
        {
            return Vector3.Normalize(2 * (float)IloczynSkalarny(N, L) * N - L);
        }

        public static double IloczynSkalarny(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        // cosinus kąta liczymy z iloczynu skalarnego wersorów N i L , np. cos(kąt(N,L)) = Nx*Lx+Ny*Ly+Nz*Lz 
        public static double CalculateCos(Vector3 a, Vector3 b)
        {
            double cos = IloczynSkalarny(a, b);
            return cos > 0 ? cos : 0;
        }

        public static Color CalculateColor(Vector3 N, Vector3 L, Vector3 V, Vector3 R, Color IL, Color IO, double kd, double ks, int m)
        {
            double cosNL = CalculateCos(N, L);
            double cosVR = CalculateCos(V, R);

            double colorR = kd * ((double)IL.R/255) * (((double)IO.R/255) * cosNL + ks * ((double)IL.R / 255) * ((double)IO.R/255) * Math.Pow(cosVR, m));
            double colorG = kd * ((double)IL.G / 255) * (((double)IO.G / 255) * cosNL + ks * ((double)IL.G / 255) * ((double)IO.G / 255) * Math.Pow(cosVR, m));
            double colorB = kd * ((double)IL.B / 255) * (((double)IO.B / 255) * cosNL + ks * ((double)IL.B / 255) * ((double)IO.B / 255) * Math.Pow(cosVR, m));

            int r = (int)(colorR * 255);
            int g = (int)(colorG * 255);
            int b = (int)(colorB * 255);

            if (r > 255) r = 255;
            if (g > 255) g = 255;
            if (b > 255) b = 255;

            if(r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;

            return Color.FromArgb(r,g,b);
        }

        public static double CalculateArea(Point p1, Point p2, Point p3)
        {
            return 0.5 * Math.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y));
        }
    }
}
