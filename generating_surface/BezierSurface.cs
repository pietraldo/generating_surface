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
    }
}
