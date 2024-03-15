namespace Rita
{
    public partial class Rita : Form
    {
        public Rita()
        {
            InitializeComponent();

            bitmap = new Bitmap(picBox.Width, picBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            picBox.Image = bitmap;

        }

        Bitmap bitmap;
        Graphics graphics;
        bool isDrawing = false;
        Point x, y;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 30);
        int index = 0;

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            y = e.Location;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (index == 0)
                {
                    x = e.Location;
                    graphics.DrawLine(pen, x, y);
                    y = x;
                }
                if (index == 1)
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
            index = 0;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}
