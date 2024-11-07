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

        int n = 30;

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


            BezierSurface surface = new BezierSurface();
            if (!surface.ReadPointsFromFile(surfaceFile))
            {
                MessageBox.Show("B³¹d wczytywania pliku");
                return;
            }

            float degreeX = trackBarAxisX.Value;
            float degreeZ = trackBarAxisZ.Value;
            float degreeY = trackBarAxisY.Value;
            n = trackBarAccuracy.Value;

            Axis(g);
            LittleGrid(surface, g, degreeX, degreeY, degreeZ);
            MainGrid(surface, g, degreeX, degreeY, degreeZ);

        }

        private void Axis(Graphics g)
        {
            if (!checkBoxAxis.Checked) return;
            g.DrawLine(Pens.Black, 0, canvasTop, 0, canvasBottom);
            g.DrawLine(Pens.Black, canvasLeft, 0, canvasRight, 0);
        }

        private void LittleGrid(BezierSurface surface, Graphics g, float degreeX, float degreeY, float degreeZ)
        {
            if (!checkBoxLittleGrid.Checked) return;

            Vector3[,] points = new Vector3[n, n];
            float step = 1f / (n - 1);

            // counting points, rotating and drawing them
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    points[i, j] = surface.CountPoint(i * step, j * step);

                    points[i, j] = BezierSurface.RotateX(points[i, j], degreeX);
                    points[i, j] = BezierSurface.RotateZ(points[i, j], degreeZ);
                    points[i, j] = BezierSurface.RotateY(points[i, j], degreeY);

                    PutPixel(g, (int)points[i, j].X, (int)points[i, j].Y, Color.Black);
                }
            }

            // drawing lines
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Point p1 = new Point((int)points[i, j].X, (int)points[i, j].Y);
                    if (j + 1 < n)
                    {
                        Point p2 = new Point((int)points[i, j + 1].X, (int)points[i, j + 1].Y);
                        g.DrawLine(Pens.Black, p1, p2);
                    }
                    if (i + 1 < n)
                    {
                        Point p3 = new Point((int)points[i + 1, j].X, (int)points[i + 1, j].Y);
                        g.DrawLine(Pens.Black, p1, p3);
                    }
                    if (i + 1 < n && j + 1 < n)
                    {
                        Point p4 = new Point((int)points[i + 1, j + 1].X, (int)points[i + 1, j + 1].Y);
                        g.DrawLine(Pens.Black, p1, p4);
                    }

                }
            }
            
            // filling triangles
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    Point p1 = new Point((int)points[i, j].X, (int)points[i, j].Y);
                    Point p2 = new Point((int)points[i, j + 1].X, (int)points[i, j + 1].Y);
                    Point p3 = new Point((int)points[i + 1, j].X, (int)points[i + 1, j].Y);
                    Point p4 = new Point((int)points[i + 1, j + 1].X, (int)points[i + 1, j + 1].Y);
                    FillTriangle(g, p1, p2, p4, Color.Yellow);
                    FillTriangle(g, p1, p3, p4, Color.Black);
                }
            }

        }

        private void MainGrid(BezierSurface surface, Graphics g, float degreeX, float degreeY, float degreeZ)
        {

            //rotating points of the main grid
            Vector3[,] rotated = new Vector3[BezierSurface.size, BezierSurface.size];
            for (int i = 0; i < BezierSurface.size; i++)
            {
                for (int j = 0; j < BezierSurface.size; j++)
                {
                    rotated[i, j] = BezierSurface.RotateX(surface.siatka[i, j], degreeX);
                    rotated[i, j] = BezierSurface.RotateZ(rotated[i, j], degreeZ);
                    rotated[i, j] = BezierSurface.RotateY(rotated[i, j], degreeY);
                }
            }

            // main grid
            if (checkBoxMainPoints.Checked)
            {

                for (int i = 0; i < BezierSurface.size; i++)
                {
                    for (int j = 0; j < BezierSurface.size; j++)
                    {
                        PutPixel(g, (int)rotated[i, j].X, (int)rotated[i, j].Y, Color.Black, 4);
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
                        Point p1 = new Point((int)rotated[i, j].X, (int)rotated[i, j].Y);
                        if (j + 1 < BezierSurface.size)
                        {
                            Point p2 = new Point((int)rotated[i, j + 1].X, (int)rotated[i, j + 1].Y);
                            g.DrawLine(Pens.Black, p1, p2);
                        }
                        if (i + 1 < BezierSurface.size)
                        {
                            Point p3 = new Point((int)rotated[i + 1, j].X, (int)rotated[i + 1, j].Y);
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

        private void FillTriangle(Graphics g, Point p1, Point p2, Point p3, Color color)
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
                    for(int j=x1; j < x2; j++)
                    {
                        int red = color.R;
                        int green = new Random().Next(256);
                        int blue = 50;
                        Color customColor = Color.FromArgb(red, green, blue);
                        PutPixel(g, j, scanLine, customColor);
                    }
                }

                for (int i = 0; i < aet.Count; i++)
                {
                    aet[i].xMin += aet[i].m;
                }

                scanLine++;
            }
        }


        Point lastMousePosition = new Point(0, 0);
        bool mouseDrag = false;
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePosition = e.Location;
            mouseDrag = true;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDrag)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
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
    }
}
