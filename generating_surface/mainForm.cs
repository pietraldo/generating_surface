namespace generating_surface
{
    public partial class mainForm : Form
    {
        const int canvasWidth = 300;
        const int canvasHeight = 300;

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
            txtAlfaValue.Text = trackBarAlfa.Value.ToString();
            txtBetaValue.Text = trackBarBeta.Value.ToString();
        }

        public static void PutPixel(Graphics g, int x, int y, Color color)
        {
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, x, y, 1, 1);
        }

        private void trackBarAlfa_Scroll(object sender, EventArgs e)
        {
            txtAlfaValue.Text = trackBarAlfa.Value.ToString();
            canvas.Invalidate();
        }

        private void trackBarBeta_Scroll(object sender, EventArgs e)
        {
            txtBetaValue.Text = trackBarBeta.Value.ToString();
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.ScaleTransform(1, -1);
            g.TranslateTransform((float)canvas.Width / 2, -(float)canvas.Height / 2);


            BezierSurface surface = new BezierSurface();

            if (surface.ReadPointsFromFile("surface.txt"))
            {
                surface.Print();

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        PutPixel(g, (int)surface.siatka[i, j].X, (int)surface.siatka[i, j].Y, Color.Black);
                    }
                }
            }
            else
            {
                MessageBox.Show("B³¹d wczytywania pliku");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
