using System.Diagnostics;
using System.Numerics;

namespace generating_surface
{
    public partial class mainForm : Form
    {
        const string surfaceFile = "surface.txt";
        
        const int canvasWidth = 300;
        const int canvasHeight = 300;

        const int n = 30;

        const int canvasRight = canvasWidth / 2;
        const int canvasLeft = -canvasWidth / 2;
        const int canvasTop = canvasHeight / 2;
        const int canvasBottom = -canvasHeight / 2;



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


        }

        public static void PutPixel(Graphics g, int x, int y, Color color, int size = 1)
        {
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, x - size / 2, y - size / 2, size, size);
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

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.ScaleTransform(1, -1);
            g.TranslateTransform((float)canvas.Width / 2, -(float)canvas.Height / 2);


            BezierSurface surface = new BezierSurface();
            
            float degreeX = trackBarAxisX.Value;
            float degreeZ = trackBarAxisZ.Value;
            float degreeY = trackBarAxisY.Value;

            if (surface.ReadPointsFromFile(surfaceFile))
            {

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

                ////rotating points of the main grid
                //Vector3[,] rotated = new Vector3[BezierSurface.size, BezierSurface.size];
                //for (int i = 0; i < BezierSurface.size; i++)
                //{
                //    for (int j = 0; j < BezierSurface.size; j++)
                //    {
                //        rotated[i, j] = BezierSurface.RotateX(surface.siatka[i, j], degreeX);
                //        rotated[i, j] = BezierSurface.RotateZ(rotated[i, j], degreeZ);
                //        rotated[i, j] = BezierSurface.RotateY(rotated[i, j], degreeY);
                //    }
                //}

                //// main grid
                //for (int i = 0; i < BezierSurface.size; i++)
                //{
                //    for (int j = 0; j < BezierSurface.size; j++)
                //    {
                //        PutPixel(g, (int)rotated[i, j].X, (int)rotated[i, j].Y, Color.Black, 4);
                //    }
                //}

                ////main grid lines
                //for (int i = 0; i < BezierSurface.size; i++)
                //{
                //    for (int j = 0; j < BezierSurface.size; j++)
                //    {
                //        Point p1 = new Point((int)rotated[i, j].X, (int)rotated[i, j].Y);
                //        if (j + 1 < BezierSurface.size)
                //        {
                //            Point p2 = new Point((int)rotated[i, j + 1].X, (int)rotated[i, j + 1].Y);
                //            g.DrawLine(Pens.Black, p1, p2);
                //        }
                //        if (i + 1 < BezierSurface.size)
                //        {
                //            Point p3 = new Point((int)rotated[i + 1, j].X, (int)rotated[i + 1, j].Y);
                //            g.DrawLine(Pens.Black, p1, p3);
                //        }

                //    }
                //}
            }
            else
            {
                MessageBox.Show("B��d wczytywania pliku");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
        }
    }
}
