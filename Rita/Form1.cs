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
        private Tool activeTool = Tool.Pen;
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

            if (activeTool == Tool.Circle)
            {
                shape = new Circle { StartPoint = startPoint };
            }

            if (activeTool == Tool.Square)
            {
                shape = new Square { StartPoint = startPoint };
            }

            if (activeTool == Tool.Triangle)
            {
                shape = new Triangle { StartPoint = startPoint };
            }
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (activeTool == Tool.Pen)
                {
                    startPoint = e.Location;
                    graphics.DrawLine(pen, startPoint, currentPoint);
                    currentPoint = startPoint;
                }
                if (activeTool == Tool.Eraser)
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
            activeTool = Tool.Pen;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Eraser;
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
            activeTool = Tool.Circle;
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
            activeTool = Tool.Square;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Triangle;
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            PerformUndo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            PerformRedo();
        }

        private void SaveToFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save an Image File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(saveFileDialog.FileName);
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.bmp";
                openFileDialog.Title = "Open an Image File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap loadedImage = new Bitmap(openFileDialog.FileName);

                    if (bitmap != null)
                        bitmap.Dispose();

                    bitmap = loadedImage;
                    graphics = Graphics.FromImage(bitmap);
                    picBox.Image = bitmap;
                    picBox.Refresh();

                    redoStack.Clear();
                    undoStack.Clear();
                }
            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
