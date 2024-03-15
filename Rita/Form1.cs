namespace Rita
{
    public partial class Rita : Form
    {
        public Rita()
        {
            InitializeComponent();

            bitmap = new Bitmap(picBox.Width, picBox.Height);
            graphics = Graphics.FromImage(bitmap);
            picBox.Image = bitmap;
        }

        Bitmap bitmap;
        Graphics graphics;
        bool isDrawing = false;
        Point x, y;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 30);
        int toolIndex = 0;

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            y = e.Location;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (toolIndex == 0)
                {
                    x = e.Location;
                    graphics.DrawLine(pen, x, y);
                    y = x;
                }
                if (toolIndex == 1)
                {
                    x = e.Location;
                    graphics.DrawLine(eraser, x, y);
                    y = x;
                }
            }
            picBox.Refresh();
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            toolIndex = 0;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolIndex = 1;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Black, 1);
            pen = newPen;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Red, 1);
            pen = newPen;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Orange, 1);
            pen = newPen;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Yellow, 1);
            pen = newPen;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Lime, 1);
            pen = newPen;
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Cyan, 1);
            pen = newPen;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Blue, 1);
            pen = newPen;
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Magenta, 1);
            pen = newPen;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            picBox.Refresh();
        }
    }
}
