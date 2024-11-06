using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace generating_surface
{
    public class BezierSurface
    {
        public const int size = 4;
        public Vector3[,] siatka = new Vector3[size, size];


        public BezierSurface()
        {
        }

        public bool ReadPointsFromFile(string file)
        {
            if (!File.Exists(file)) return false;

            using (StreamReader sr = new StreamReader(file))
            {
                string? line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i >= size * size) return false;

                    string[] values = line.Split(' ');
                    if (values.Length != 3) return false;

                    siatka[i / size, i % size] = new Vector3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));

                    i++;
                }

                if (i != size*size) return false;
            }

            return true;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Debug.Write(siatka[i, j]);
                    Debug.Write(" ");
                }
                Debug.WriteLine("");
            }
        }

        public static Vector3 RotateX(Vector3 v, float degree)
        {
            Vector3 rotated = new Vector3();

            float radian = (float)(degree * Math.PI / 180);

            rotated.X = v.X;
            rotated.Y = (float)(v.Y * Math.Cos(radian) - v.Z * Math.Sin(radian));
            rotated.Z = (float)(v.Y * Math.Sin(radian) + v.Z * Math.Cos(radian));
            return rotated;
        }
        public static Vector3 RotateZ(Vector3 v, float degree)
        {
            Vector3 rotated = new Vector3();

            float radian = (float)(degree * Math.PI / 180);

            rotated.X = (float)(v.X * Math.Cos(radian) - v.Y * Math.Sin(radian));
            rotated.Y = (float)(v.X * Math.Sin(radian) + v.Y * Math.Cos(radian));
            rotated.Z = v.Z;
            return rotated;
        }
        public static Vector3 RotateY(Vector3 v, float degree)
        {
            Vector3 rotated = new Vector3();

            float radian = (float)(degree * Math.PI / 180);

            rotated.X = (float)(v.X * Math.Cos(radian) + v.Z * Math.Sin(radian));
            rotated.Y = v.Y;
            rotated.Z = (float)(-v.X * Math.Sin(radian) + v.Z * Math.Cos(radian));
            return rotated;
        }

        public Vector3 CountPoint(float u, float v)
        {
            Vector3 point = new Vector3(0,0,0);
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    float bernsteinU = (float)Bernstein(u, i, size -1);
                    float bernsteinV = (float)Bernstein(v, j, size -1);

                    point.X += siatka[i, j].X * bernsteinU * bernsteinV;
                    point.Y += siatka[i, j].Y * bernsteinU * bernsteinV;
                    point.Z += siatka[i, j].Z * bernsteinU * bernsteinV;
                }
            }
            return point;
        }
        public static double Bernstein(float u, int i, int m)
        {
            return BinominalCoefficient(m, i) * Math.Pow(u, i) * Math.Pow(1 - u, m - i);
        }

        public static int BinominalCoefficient(int n, int k)
        {
            if (k == 0 || k == n) return 1;
            return BinominalCoefficient(n - 1, k - 1) + BinominalCoefficient(n - 1, k);
        }
    }
}
