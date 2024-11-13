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
        public int size;

        public Vector3[,] start_points;
        public Vector3[,] rotated_points;

        public Vertex[,] small_grid;
        public int small_grid_size;

        public float degreeX = 0;
        public float degreeY = 0;
        public float degreeZ = 0;


        public BezierSurface()
        {
        }

        public void RotatePoints()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    rotated_points[i, j] = start_points[i, j];
                    rotated_points[i, j] = RotateX(rotated_points[i, j], degreeX);
                    rotated_points[i, j] = RotateY(rotated_points[i, j], degreeY);
                    rotated_points[i, j] = RotateZ(rotated_points[i, j], degreeZ);
                }
            }
        }

        public void GenerateSmallGrid()
        {
            int n = small_grid_size;
            small_grid = new Vertex[n, n];

            float step = 1f / (n - 1);

            // counting points, rotating and drawing them
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    small_grid[i, j] = new Vertex();
                    small_grid[i, j].start_point = CountPoint(i * step, j * step);

                    small_grid[i, j].u = i * step;
                    small_grid[i, j].v = j * step;

                    small_grid[i, j].rotated_point = small_grid[i, j].start_point;
                    small_grid[i, j].rotated_point = BezierSurface.RotateX(small_grid[i, j].rotated_point, degreeX);
                    small_grid[i, j].rotated_point = BezierSurface.RotateZ(small_grid[i, j].rotated_point, degreeZ);
                    small_grid[i, j].rotated_point = BezierSurface.RotateY(small_grid[i, j].rotated_point, degreeY);
                }
            }
        }

        public void CalculateVectorsForPoints(Vector3 sunPosition, Bitmap? texture)
        {
            for (int i = 0; i < small_grid_size; i++)
            {
                for (int j = 0; j < small_grid_size; j++)
                {                    
                    if (texture != null)
                    {
                        int width = (int)(small_grid[i, j].u * texture.Width);
                        int height = (int)(small_grid[i, j].v * texture.Height);
                        width = Math.Min(width, texture.Width - 1);
                        height = Math.Min(height, texture.Height - 1);
                        width = Math.Max(width, 1);
                        height = Math.Max(height, 1);
                        Color color = texture.GetPixel(width, height);
                        Vector3 vector3 = new Vector3(color.R - 128, color.G - 128, color.B - 128);
                        small_grid[i, j].N = Vector3.Normalize(vector3);
                    }
                    else
                    {
                        small_grid[i, j].N = FillingTriangle.CalculateN(small_grid[i, j].u, small_grid[i, j].v, this);
                    }

                    small_grid[i, j].L = Vector3.Normalize(sunPosition - small_grid[i, j].rotated_point);
                    small_grid[i, j].V = new Vector3(0, 0, 1);
                    small_grid[i, j].R = FillingTriangle.CalculateR(small_grid[i, j].N, small_grid[i, j].L);
                }
            }
        }

        public bool ReadPointsFromFile(string file)
        {
            if (!File.Exists(file)) return false;

            size = (int)Math.Sqrt(File.ReadLines(file).Count());
            start_points = new Vector3[size, size];
            rotated_points = new Vector3[size, size];

            using (StreamReader sr = new StreamReader(file))
            {
                string? line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i >= size * size) return false;

                    string[] values = line.Split(' ');
                    if (values.Length != 3) return false;

                    start_points[i / size, i % size] = new Vector3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));

                    i++;
                }

                if (i != size*size) return false;
            }

            return true;
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

                    point.X += start_points[i, j].X * bernsteinU * bernsteinV;
                    point.Y += start_points[i, j].Y * bernsteinU * bernsteinV;
                    point.Z += start_points[i, j].Z * bernsteinU * bernsteinV;
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
