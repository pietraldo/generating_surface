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

            canvas.Size = new System.Drawing.Size(canvasWidth, canvasHeight);
            canvas.Location = new Point(0, 0);

            trackBar1.Minimum = canvasLeft;
            trackBar1.Maximum = canvasRight;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.ScaleTransform(1, -1);
            g.TranslateTransform((float)canvas.Width / 2, -(float)canvas.Height / 2);


            int red = 255;
            int green = 100;
            int blue = 50;
            Color customColor = Color.FromArgb(red, green, blue);
            Brush customBrush = new SolidBrush(customColor);

            g.FillRectangle(customBrush, trackBar1.Value, 0, 2, 2);

        }
    }
}
