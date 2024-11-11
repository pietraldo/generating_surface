using System.Collections.Immutable;
using System.Diagnostics;
using System.Numerics;

namespace generating_surface
{
    public partial class mainForm : Form
    {
        const string surfaceFile = "surface.txt";

        const int canvasWidth = 500;
        const int canvasHeight = 500;

        const int canvasRight = canvasWidth / 2;
        const int canvasLeft = -canvasWidth / 2;
        const int canvasTop = canvasHeight / 2;
        const int canvasBottom = -canvasHeight / 2;

        BezierSurface surface;
        Vector3 sunPosition = new Vector3(0, 0, 0);

        public mainForm()
        {
            InitializeComponent();

            // Canvas
            canvas.Size = new System.Drawing.Size(canvasWidth, canvasHeight);
            canvas.Location = new Point(0, 0);

            // TrackBar
            txtAxisXValue.Text = trackBarAxisX.Value.ToString();
            txtAxisZValue.Text = trackBarAxisZ.Value.ToString();
            txtAxisYValue.Text = trackBarAxisY.Value.ToString();
            txtAccuracy.Text = trackBarAccuracy.Value.ToString();


            surface = new BezierSurface();
            if (!surface.ReadPointsFromFile(surfaceFile))
            {
                MessageBox.Show("B³¹d wczytywania pliku");
            }
        }

        public static void PutPixel(Graphics g, int x, int y, Color color, int size = 1)
        {
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, x - size / 2, y - size / 2, size, size);
        }



        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.ScaleTransform(1, -1);
            g.TranslateTransform((float)canvas.Width / 2, -(float)canvas.Height / 2);


            surface.degreeX = trackBarAxisX.Value;
            surface.degreeY = trackBarAxisY.Value;
            surface.degreeZ = trackBarAxisZ.Value;
            surface.small_grid_size = trackBarAccuracy.Value;

            surface.RotatePoints();
            surface.GenerateSmallGrid();

            PaintAxis(g);
            PaintMainGrid(g);
            PaintLittleGrid(g);
            PaintSun(g);

        }

        private void PaintAxis(Graphics g)
        {
            if (!checkBoxAxis.Checked) return;
            g.DrawLine(Pens.Black, 0, canvasTop, 0, canvasBottom);
            g.DrawLine(Pens.Black, canvasLeft, 0, canvasRight, 0);
        }

        private void PaintSun(Graphics g)
        {
            // interpolate color based on z position of the sun
            float zPosition = sunPosition.Z;
            zPosition = Math.Clamp(zPosition, -500, 500);

            float t = (zPosition + 500) / 1000f;

            int r1 = 139, g1 = 0, b1 = 0;
            int r2 = 255, g2 = 255, b2 = 0;

            int r_color = (int)(r1 + (r2 - r1) * t);
            int g_color = (int)(g1 + (g2 - g1) * t);
            int b_color = (int)(b1 + (b2 - b1) * t);

            Brush brush = new SolidBrush(Color.FromArgb(r_color, g_color, b_color));
            g.FillRectangle(brush, sunPosition.X, sunPosition.Y, 10, 10);
        }
        private void PaintLittleGrid(Graphics g)
        {
            if (!checkBoxLittleGrid.Checked) return;

            for (int i = 0; i < surface.small_grid_size; i++)
            {
                for (int j = 0; j < surface.small_grid_size; j++)
                {
                    Vertex vertex = surface.small_grid[i, j];
                    Color color = CalculateColor(vertex.u, vertex.v, vertex.rotated_point);

                    PutPixel(g, (int)vertex.rotated_point.X, (int)vertex.rotated_point.Y, color, 2);
                }
            }

            // drawing lines
            for (int i = 0; i < surface.small_grid_size; i++)
            {
                for (int j = 0; j < surface.small_grid_size; j++)
                {
                    Point p1 = new Point((int)surface.small_grid[i, j].rotated_point.X, (int)surface.small_grid[i, j].rotated_point.Y);
                    if (j + 1 < surface.small_grid_size)
                    {
                        Point p2 = new Point((int)surface.small_grid[i, j + 1].rotated_point.X, (int)surface.small_grid[i, j + 1].rotated_point.Y);
                        g.DrawLine(Pens.Black, p1, p2);
                    }
                    if (i + 1 < surface.small_grid_size)
                    {
                        Point p3 = new Point((int)surface.small_grid[i + 1, j].rotated_point.X, (int)surface.small_grid[i + 1, j].rotated_point.Y);
                        g.DrawLine(Pens.Black, p1, p3);
                    }
                    if (i + 1 < surface.small_grid_size && j + 1 < surface.small_grid_size)
                    {
                        Point p4 = new Point((int)surface.small_grid[i + 1, j + 1].rotated_point.X, (int)surface.small_grid[i + 1, j + 1].rotated_point.Y);
                        g.DrawLine(Pens.Black, p1, p4);
                    }

                }
            }

            //// filling triangles
            for (int i = 0; i < surface.small_grid_size - 1; i++)
            {
                for (int j = 0; j < surface.small_grid_size - 1; j++)
                {
                    Point p1 = new Point((int)surface.small_grid[i, j].rotated_point.X, (int)surface.small_grid[i, j].rotated_point.Y);
                    Point p2 = new Point((int)surface.small_grid[i, j + 1].rotated_point.X, (int)surface.small_grid[i, j + 1].rotated_point.Y);
                    Point p3 = new Point((int)surface.small_grid[i + 1, j].rotated_point.X, (int)surface.small_grid[i + 1, j].rotated_point.Y);
                    Point p4 = new Point((int)surface.small_grid[i + 1, j + 1].rotated_point.X, (int)surface.small_grid[i + 1, j + 1].rotated_point.Y);
                    FillTriangle(g, p1, p2, p4, Color.Yellow, surface);
                    FillTriangle(g, p1, p3, p4, Color.Black, surface);
                }
            }

        }

        private void PaintMainGrid(Graphics g)
        {
            // main grid
            if (checkBoxMainPoints.Checked)
            {
                for (int i = 0; i < BezierSurface.size; i++)
                {
                    for (int j = 0; j < BezierSurface.size; j++)
                    {
                        PutPixel(g, (int)surface.rotated_points[i, j].X, (int)surface.rotated_points[i, j].Y, Color.Black, 4);
                    }
                }
            }

            //main grid lines
            if (checkBoxMainLines.Checked)
            {
                for (int i = 0; i < BezierSurface.size; i++)
                {
                    for (int j = 0; j < BezierSurface.size; j++)
                    {
                        Point p1 = new Point((int)surface.rotated_points[i, j].X, (int)surface.rotated_points[i, j].Y);
                        if (j + 1 < BezierSurface.size)
                        {
                            Point p2 = new Point((int)surface.rotated_points[i, j + 1].X, (int)surface.rotated_points[i, j + 1].Y);
                            g.DrawLine(Pens.Black, p1, p2);
                        }
                        if (i + 1 < BezierSurface.size)
                        {
                            Point p3 = new Point((int)surface.rotated_points[i + 1, j].X, (int)surface.rotated_points[i + 1, j].Y);
                            g.DrawLine(Pens.Black, p1, p3);
                        }

                    }
                }
            }
        }

        private class Edge
        {
            public int yMax;
            public double xMin;
            public double m;
            public int index;
        }

        private void FillTriangle(Graphics g, Point p1, Point p2, Point p3, Color color, BezierSurface surface)
        {
            // Sort points by Y coordinate in ascending order
            Point[] points = { p1, p2, p3 };
            Array.Sort(points, (a, b) => a.Y.CompareTo(b.Y));

            int ymin = points[0].Y;
            int ymax = points[2].Y;
            int scanLine = ymin;

            List<Edge> aet = new List<Edge>();

            while (scanLine <= ymax)
            {
                for (int i = 0; i < points.Length; i++)
                {
                    int prevI = (i + 2) % 3;
                    int nextI = (i + 1) % 3;
                    Point curr = points[i];
                    Point prev = points[prevI];
                    Point next = points[nextI];

                    if (curr.Y == scanLine)
                    {
                        if (prev.Y > curr.Y)
                        {
                            aet.Add(new Edge
                            {
                                yMax = prev.Y,
                                xMin = curr.X,
                                m = (prev.Y == curr.Y) ? 0 : (float)(prev.X - curr.X) / (prev.Y - curr.Y),
                                index = i
                            });
                        }

                        if (next.Y > curr.Y)
                        {
                            aet.Add(new Edge
                            {
                                yMax = next.Y,
                                xMin = curr.X,
                                m = (next.Y == curr.Y) ? 0 : (float)(next.X - curr.X) / (next.Y - curr.Y),
                                index = i
                            });
                        }
                    }
                }

                aet.RemoveAll(edge => edge.yMax <= scanLine);

                aet.Sort((a, b) => a.xMin.CompareTo(b.xMin));

                for (int i = 0; i < aet.Count - 1; i += 2)
                {
                    int x1 = (int)aet[i].xMin;
                    int x2 = (int)aet[i + 1].xMin;
                    for (int j = x1; j < x2; j++)
                    {
                        //float u = 2;
                        //float v = 2;
                        //color = CalculateColor(u, v, surface);
                        PutPixel(g, j, scanLine, color);
                    }
                }

                for (int i = 0; i < aet.Count; i++)
                {
                    aet[i].xMin += aet[i].m;
                }

                scanLine++;
            }
        }

        private Color CalculateColor(float u, float v, Vector3 pointPosition)
        {
            Vector3 L = Vector3.Normalize(sunPosition-pointPosition);
            Vector3 N = FillingTriangle.CalculateN(u, v, surface);
            Vector3 R = FillingTriangle.CalculateR(N, L);
            Vector3 V = new Vector3(0, 0, 1);
            Color IL = Color.White;
            Color IO = Color.LightBlue;
            double kd = (double)trackBarKd.Value / 1000;
            double ks = (double)trackBarKs.Value / 1000;
            int m = trackBarM.Value;


            return FillingTriangle.CalculateColor(N, L, V, R, IL, IO, kd, ks, m);
        }


        Point lastMousePosition = new Point(0, 0);
        bool mouseDrag = false;
        bool sun = false;
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePosition = e.Location;
            mouseDrag = true;
            sun = e.Button == MouseButtons.Right;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDrag && !sun)
            {
                float dy = e.Location.X - lastMousePosition.X;
                float dx = e.Location.Y - lastMousePosition.Y;

                if (dx + trackBarAxisX.Value < trackBarAxisX.Maximum && dx + trackBarAxisX.Value > trackBarAxisX.Minimum)
                    trackBarAxisX.Value += (int)dx;
                if (dy + trackBarAxisY.Value < trackBarAxisY.Maximum && dy + trackBarAxisY.Value > trackBarAxisY.Minimum)
                    trackBarAxisY.Value += (int)dy;


                lastMousePosition = e.Location;

                canvas.Invalidate();
            }
            else if (mouseDrag)
            {
                int newX = e.Location.X-canvasWidth/2;
                int newY = -(e.Location.Y-canvasHeight/2);

                Vector3 newSunPosition = new Vector3(newX, newY, sunPosition.Z);
                UpdateSunPosition(newSunPosition);

                lastMousePosition = e.Location;
                canvas.Invalidate();
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
        }

        private void trackBarAlfa_Scroll(object sender, EventArgs e)
        {
            txtAxisXValue.Text = trackBarAxisX.Value.ToString();
            canvas.Invalidate();
        }

        private void trackBarBeta_Scroll(object sender, EventArgs e)
        {
            txtAxisZValue.Text = trackBarAxisZ.Value.ToString();
            canvas.Invalidate();
        }
        private void trackBarAxisY_Scroll(object sender, EventArgs e)
        {
            txtAxisYValue.Text = trackBarAxisY.Value.ToString();
            canvas.Invalidate();
        }



        private void checkBoxLittleGrid_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void checkBoxMainLines_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void checkBoxMainPoints_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void checkBoxAxis_CheckedChanged(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void trackBarAccuracy_Scroll(object sender, EventArgs e)
        {
            txtAccuracy.Text = trackBarAccuracy.Value.ToString();
            canvas.Invalidate();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColor.BackColor = colorDialog1.Color;
        }

        private void trackBarKd_Scroll(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void trackBarKs_Scroll(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void trackBarM_Scroll(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void UpdateSunPosition(Vector3 newSunPosition)
        {
            sunPosition = newSunPosition;
            txtSunX.Text = sunPosition.X.ToString();
            txtSunY.Text = sunPosition.Y.ToString();
            txtSunZ.Text = sunPosition.Z.ToString();

            trackBarSunX.Value = (int)sunPosition.X;
            trackBarSunY.Value = (int)sunPosition.Y;
            trackBarSunZ.Value = (int)sunPosition.Z;
        }


        
        

        private void trackBarSunX_Scroll(object sender, EventArgs e)
        {
            int sunX = trackBarSunX.Value;
            Vector3 pos=sunPosition;
            pos.X = sunX;
            UpdateSunPosition(pos);
            canvas.Invalidate();
        }

        private void trackBarSunY_Scroll(object sender, EventArgs e)
        {
            int sunY = trackBarSunY.Value;
            Vector3 pos = sunPosition;
            pos.Y = sunY;
            UpdateSunPosition(pos);
            canvas.Invalidate();
        }

        private void trackBarSunZ_Scroll(object sender, EventArgs e)
        {
            int sunZ = trackBarSunZ.Value;
            Vector3 pos = sunPosition;
            pos.Z = sunZ;
            UpdateSunPosition(pos);
            canvas.Invalidate();
        }
    }
}
