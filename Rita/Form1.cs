using System.Drawing;

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

        private Bitmap bitmap;
        private Graphics graphics;
        private bool isDrawing = false;
        private Point startPoint, currentPoint;
        private Pen pen = new Pen(Color.Black, 1);
        private Pen eraser = new Pen(Color.White, 30);
        private int toolIndex = 0;
        private Shape? shape = null;
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();

        private void CopyBitmapForUndo()
        {
            Bitmap copy = (Bitmap)bitmap.Clone();
            undoStack.Push(copy);
        }

        private void PerformUndo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push((Bitmap)bitmap.Clone());
                bitmap.Dispose();
                bitmap = undoStack.Pop();
                graphics = Graphics.FromImage(bitmap);
                picBox.Image = bitmap;
                picBox.Refresh();
            }
        }

        private void PerformRedo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push((Bitmap)bitmap.Clone());
                bitmap.Dispose();
                bitmap = redoStack.Pop();
                graphics = Graphics.FromImage(bitmap);
                picBox.Image = bitmap;
                picBox.Refresh();
            }
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {

            CopyBitmapForUndo();

            isDrawing = true;
            startPoint = e.Location;
            currentPoint = e.Location;

            if (toolIndex == 2)
            {
                shape = new Circle { StartPoint = startPoint };
            }

            if (toolIndex == 3)
            {
                shape = new Square { StartPoint = startPoint };
            }

            if (toolIndex == 4)
            {
                shape = new Triangle { StartPoint = startPoint };
            }
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (toolIndex == 0)
                {
                    startPoint = e.Location;
                    graphics.DrawLine(pen, startPoint, currentPoint);
                    currentPoint = startPoint;
                }
                if (toolIndex == 1)
                {
                    startPoint = e.Location;
                    graphics.DrawLine(eraser, startPoint, currentPoint);
                    currentPoint = startPoint;
                }
                if (shape != null)
                {
                    shape.EndPoint = e.Location;
                }
            }
            picBox.Refresh();
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            if (shape != null)
            {
                shape.Draw(graphics, pen);
                shape = null;
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            toolIndex = 0;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolIndex = 1;
        }

        private void ChangePenColor(Color color)
        {
            if (pen != null) pen.Dispose();
            pen = new Pen(color, 1);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Black);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Red);
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Orange);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Yellow);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Lime);
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Cyan);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Blue);
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Magenta);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CopyBitmapForUndo();

            graphics.Clear(Color.White);
            picBox.Refresh();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            toolIndex = 2;
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null && isDrawing)
            {
                shape.Draw(e.Graphics, pen);
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            toolIndex = 3;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            toolIndex = 4;
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            PerformUndo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            PerformRedo();
        }
    }
}
