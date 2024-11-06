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
        public Vector3[,] siatka = new Vector3[4, 4];


        public BezierSurface()
        {
        }

        public bool ReadPointsFromFile(string file)
        {
            if(!File.Exists(file)) return false;
                
            using (StreamReader sr = new StreamReader(file))
            {
                string? line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(' ');
                    if(values.Length!=3) return false;
                    
                    siatka[i/4, i%4] = new Vector3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));
                    
                    i++;
                }

                if(i!=16) return false;
            }

            return true;
        }

        public void Print()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Debug.Write(siatka[i, j]);
                    Debug.Write(" ");
                }
                Debug.WriteLine("");
            }
        }

        public static Vector3 RotateX(Vector3 v, float degree)
        {
            Vector3 rotated= new Vector3();

            float radian = (float)(degree * Math.PI / 180);

            rotated.X = v.X;
            rotated.Y = (float)(v.Y * Math.Cos(radian) - v.Z * Math.Sin(radian));
            rotated.Z = (float)(v.Y * Math.Sin(radian) + v.Z * Math.Cos(radian));
            return rotated;
        }
        public static Vector3 RotateZ(Vector3 v, float degree)
        {
            Vector3 rotated= new Vector3();

            float radian = (float)(degree * Math.PI / 180);

            rotated.X = (float)(v.X * Math.Cos(radian) - v.Y * Math.Sin(radian));
            rotated.Y = (float)(v.X * Math.Sin(radian) + v.Y * Math.Cos(radian));
            rotated.Z = v.Z;
            return rotated;
        }
        public static Vector3 RotateY(Vector3 v, float degree)
        {
            Vector3 rotated= new Vector3();

            float radian = (float)(degree * Math.PI / 180);

            rotated.X = (float)(v.X * Math.Cos(radian) + v.Z * Math.Sin(radian));
            rotated.Y = v.Y;
            rotated.Z = (float)(-v.X * Math.Sin(radian) + v.Z * Math.Cos(radian));
            return rotated;
        }
    }
}
