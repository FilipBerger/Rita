namespace Rita
{
    partial class Rita
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rita));
            menuStrip1 = new MenuStrip();
            File = new ToolStripMenuItem();
            Save = new ToolStripMenuItem();
            Open = new ToolStripMenuItem();
            Edit = new ToolStripMenuItem();
            Undo = new ToolStripMenuItem();
            Redo = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnBlack = new ToolStripButton();
            btnRed = new ToolStripButton();
            btnOrange = new ToolStripButton();
            btnYellow = new ToolStripButton();
            btnGreen = new ToolStripButton();
            btnCyan = new ToolStripButton();
            btnBlue = new ToolStripButton();
            btnMagenta = new ToolStripButton();
            btnPen = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            btnCircle = new ToolStripButton();
            btnSquare = new ToolStripButton();
            btnTriangle = new ToolStripButton();
            btnClear = new ToolStripButton();
            picBox = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { File, Edit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { Save, Open });
            File.Name = "File";
            File.Size = new Size(46, 24);
            File.Text = "File";
            // 
            // Save
            // 
            Save.Name = "Save";
            Save.Size = new Size(224, 26);
            Save.Text = "Save";
            // 
            // Open
            // 
            Open.Name = "Open";
            Open.Size = new Size(224, 26);
            Open.Text = "Open";
            // 
            // Edit
            // 
            Edit.DropDownItems.AddRange(new ToolStripItem[] { Undo, Redo });
            Edit.Name = "Edit";
            Edit.Size = new Size(49, 24);
            Edit.Text = "Edit";
            // 
            // Undo
            // 
            Undo.Name = "Undo";
            Undo.Size = new Size(224, 26);
            Undo.Text = "Undo";
            Undo.Click += Undo_Click;
            // 
            // Redo
            // 
            Redo.Name = "Redo";
            Redo.Size = new Size(224, 26);
            Redo.Text = "Redo";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBlack, btnRed, btnOrange, btnYellow, btnGreen, btnCyan, btnBlue, btnMagenta, btnPen, toolStripButton2, btnCircle, btnSquare, btnTriangle, btnClear });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnBlack
            // 
            btnBlack.BackColor = SystemColors.ActiveCaptionText;
            btnBlack.DisplayStyle = ToolStripItemDisplayStyle.None;
            btnBlack.Image = (Image)resources.GetObject("btnBlack.Image");
            btnBlack.ImageTransparentColor = Color.Magenta;
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(29, 24);
            btnBlack.Text = "Change color to black";
            btnBlack.Click += btnBlack_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRed.ImageTransparentColor = Color.Magenta;
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(29, 24);
            btnRed.Text = "Change color to red";
            btnRed.Click += btnRed_Click;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.FromArgb(255, 128, 0);
            btnOrange.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOrange.ImageTransparentColor = Color.Magenta;
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(29, 24);
            btnOrange.Text = "Change color to orange";
            btnOrange.Click += btnOrange_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnYellow.ImageTransparentColor = Color.Magenta;
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(29, 24);
            btnYellow.Text = "Change color to yellow";
            btnYellow.Click += btnYellow_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Lime;
            btnGreen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGreen.ImageTransparentColor = Color.Magenta;
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(29, 24);
            btnGreen.Text = "Change color to green";
            btnGreen.Click += btnGreen_Click;
            // 
            // btnCyan
            // 
            btnCyan.BackColor = Color.Cyan;
            btnCyan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCyan.ImageTransparentColor = Color.Magenta;
            btnCyan.Name = "btnCyan";
            btnCyan.Size = new Size(29, 24);
            btnCyan.Text = "Change color to cyan";
            btnCyan.Click += btnCyan_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBlue.ImageTransparentColor = Color.Magenta;
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(29, 24);
            btnBlue.Text = "Change color to blue";
            btnBlue.Click += btnBlue_Click;
            // 
            // btnMagenta
            // 
            btnMagenta.BackColor = Color.Fuchsia;
            btnMagenta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMagenta.ImageTransparentColor = Color.Magenta;
            btnMagenta.Name = "btnMagenta";
            btnMagenta.Size = new Size(29, 24);
            btnMagenta.Text = "Change color to magenta";
            btnMagenta.Click += btnMagenta_Click;
            // 
            // btnPen
            // 
            btnPen.Image = (Image)resources.GetObject("btnPen.Image");
            btnPen.ImageTransparentColor = Color.Magenta;
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(56, 24);
            btnPen.Text = "Pen";
            btnPen.Click += btnPen_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(73, 24);
            toolStripButton2.Text = "Eraser";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // btnCircle
            // 
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageTransparentColor = Color.Magenta;
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(70, 24);
            btnCircle.Text = "Circle";
            btnCircle.TextDirection = ToolStripTextDirection.Horizontal;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnSquare
            // 
            btnSquare.Image = (Image)resources.GetObject("btnSquare.Image");
            btnSquare.ImageTransparentColor = Color.Magenta;
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(79, 24);
            btnSquare.Text = "Square";
            btnSquare.Click += btnSquare_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.Image = (Image)resources.GetObject("btnTriangle.Image");
            btnTriangle.ImageTransparentColor = Color.Magenta;
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(86, 24);
            btnTriangle.Text = "Triangle";
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnClear
            // 
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 24);
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // picBox
            // 
            picBox.BackColor = Color.White;
            picBox.ErrorImage = null;
            picBox.Location = new Point(12, 69);
            picBox.Name = "picBox";
            picBox.Size = new Size(776, 369);
            picBox.TabIndex = 2;
            picBox.TabStop = false;
            picBox.Paint += picBox_Paint;
            picBox.MouseDown += picBox_MouseDown;
            picBox.MouseMove += picBox_MouseMove;
            picBox.MouseUp += picBox_MouseUp;
            // 
            // Rita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBox);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "Rita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rita";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem File;
        private ToolStripMenuItem Save;
        private ToolStripMenuItem Open;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBlack;
        private ToolStripButton btnRed;
        private ToolStripButton btnOrange;
        private ToolStripButton btnYellow;
        private ToolStripButton btnGreen;
        private ToolStripButton btnCyan;
        private ToolStripButton btnBlue;
        private ToolStripButton btnMagenta;
        private ToolStripButton btnCircle;
        private ToolStripButton btnSquare;
        private ToolStripButton btnTriangle;
        private ToolStripMenuItem Edit;
        private ToolStripMenuItem Undo;
        private ToolStripMenuItem Redo;
        private PictureBox picBox;
        private ToolStripButton btnPen;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnClear;
    }
}
