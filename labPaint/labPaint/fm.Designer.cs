namespace labPaint
{
    partial class fm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm));
            this.instpanel = new System.Windows.Forms.Panel();
            this.ClearPanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Sizepen = new System.Windows.Forms.TrackBar();
            this.Download = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.toolsBar = new System.Windows.Forms.ToolBar();
            this.arrowBtn = new System.Windows.Forms.ToolBarButton();
            this.lineBtn = new System.Windows.Forms.ToolBarButton();
            this.pencilBtn = new System.Windows.Forms.ToolBarButton();
            this.rectangleBtn = new System.Windows.Forms.ToolBarButton();
            this.ellipseBtn = new System.Windows.Forms.ToolBarButton();
            this.brushBtn = new System.Windows.Forms.ToolBarButton();
            this.fillBtn = new System.Windows.Forms.ToolBarButton();
            this.textBtn = new System.Windows.Forms.ToolBarButton();
            this.eraserBtn = new System.Windows.Forms.ToolBarButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.MouseLocation = new System.Windows.Forms.Label();
            this.StartXY = new System.Windows.Forms.Button();
            this.paImage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AllColor = new System.Windows.Forms.PictureBox();
            this.RndColor = new System.Windows.Forms.PictureBox();
            this.Fuchsia = new System.Windows.Forms.PictureBox();
            this.Blue = new System.Windows.Forms.PictureBox();
            this.Aqua = new System.Windows.Forms.PictureBox();
            this.Lime = new System.Windows.Forms.PictureBox();
            this.Yellow = new System.Windows.Forms.PictureBox();
            this.Orange = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.PictureBox();
            this.Silver = new System.Windows.Forms.PictureBox();
            this.White = new System.Windows.Forms.PictureBox();
            this.Black = new System.Windows.Forms.PictureBox();
            this.instpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sizepen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RndColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fuchsia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Silver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.White)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).BeginInit();
            this.SuspendLayout();
            // 
            // instpanel
            // 
            this.instpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.instpanel.Controls.Add(this.ClearPanel);
            this.instpanel.Controls.Add(this.panel1);
            this.instpanel.Controls.Add(this.AllColor);
            this.instpanel.Controls.Add(this.RndColor);
            this.instpanel.Controls.Add(this.Fuchsia);
            this.instpanel.Controls.Add(this.Blue);
            this.instpanel.Controls.Add(this.Aqua);
            this.instpanel.Controls.Add(this.Lime);
            this.instpanel.Controls.Add(this.Yellow);
            this.instpanel.Controls.Add(this.Orange);
            this.instpanel.Controls.Add(this.Red);
            this.instpanel.Controls.Add(this.Silver);
            this.instpanel.Controls.Add(this.White);
            this.instpanel.Controls.Add(this.Black);
            this.instpanel.Location = new System.Drawing.Point(15, 132);
            this.instpanel.Name = "instpanel";
            this.instpanel.Size = new System.Drawing.Size(782, 83);
            this.instpanel.TabIndex = 8;
            // 
            // ClearPanel
            // 
            this.ClearPanel.AutoSize = true;
            this.ClearPanel.BackColor = System.Drawing.Color.Transparent;
            this.ClearPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClearPanel.FlatAppearance.BorderSize = 0;
            this.ClearPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearPanel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearPanel.ForeColor = System.Drawing.Color.Black;
            this.ClearPanel.Location = new System.Drawing.Point(0, 0);
            this.ClearPanel.Name = "ClearPanel";
            this.ClearPanel.Size = new System.Drawing.Size(118, 83);
            this.ClearPanel.TabIndex = 15;
            this.ClearPanel.Text = "Очистить";
            this.ClearPanel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Sizepen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(254, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 83);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Min            Max\r\n";
            // 
            // Sizepen
            // 
            this.Sizepen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sizepen.Location = new System.Drawing.Point(0, 0);
            this.Sizepen.Maximum = 100;
            this.Sizepen.Minimum = 5;
            this.Sizepen.Name = "Sizepen";
            this.Sizepen.Size = new System.Drawing.Size(168, 45);
            this.Sizepen.TabIndex = 11;
            this.Sizepen.Value = 5;
            // 
            // Download
            // 
            this.Download.AutoSize = true;
            this.Download.BackColor = System.Drawing.Color.Transparent;
            this.Download.FlatAppearance.BorderSize = 0;
            this.Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download.Location = new System.Drawing.Point(223, 23);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(121, 39);
            this.Download.TabIndex = 14;
            this.Download.Text = "Загрузить";
            this.Download.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(96, 23);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 39);
            this.Save.TabIndex = 13;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // toolsBar
            // 
            this.toolsBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolsBar.AutoSize = false;
            this.toolsBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.arrowBtn,
            this.pencilBtn,
            this.brushBtn,
            this.ellipseBtn,
            this.lineBtn,
            this.rectangleBtn,
            this.fillBtn,
            this.textBtn,
            this.eraserBtn});
            this.toolsBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolsBar.DropDownArrows = true;
            this.toolsBar.Location = new System.Drawing.Point(20, 106);
            this.toolsBar.MinimumSize = new System.Drawing.Size(30, 0);
            this.toolsBar.Name = "toolsBar";
            this.toolsBar.ShowToolTips = true;
            this.toolsBar.Size = new System.Drawing.Size(30, 342);
            this.toolsBar.TabIndex = 6;
            // 
            // arrowBtn
            // 
            this.arrowBtn.ImageIndex = 0;
            this.arrowBtn.Name = "arrowBtn";
            this.arrowBtn.Tag = "0";
            // 
            // lineBtn
            // 
            this.lineBtn.ImageIndex = 4;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Tag = "1";
            // 
            // pencilBtn
            // 
            this.pencilBtn.ImageIndex = 1;
            this.pencilBtn.Name = "pencilBtn";
            this.pencilBtn.Tag = "2";
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.ImageIndex = 5;
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Tag = "3";
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.ImageIndex = 3;
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Tag = "4";
            // 
            // brushBtn
            // 
            this.brushBtn.ImageIndex = 2;
            this.brushBtn.Name = "brushBtn";
            this.brushBtn.Tag = "5";
            // 
            // fillBtn
            // 
            this.fillBtn.ImageIndex = 6;
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Tag = "6";
            // 
            // textBtn
            // 
            this.textBtn.ImageIndex = 7;
            this.textBtn.Name = "textBtn";
            this.textBtn.Tag = "7";
            // 
            // eraserBtn
            // 
            this.eraserBtn.ImageIndex = 8;
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Tag = "8";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Red;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            this.imageList.Images.SetKeyName(5, "");
            this.imageList.Images.SetKeyName(6, "");
            this.imageList.Images.SetKeyName(7, "");
            this.imageList.Images.SetKeyName(8, "");
            // 
            // MouseLocation
            // 
            this.MouseLocation.AutoSize = true;
            this.MouseLocation.BackColor = System.Drawing.Color.Transparent;
            this.MouseLocation.Location = new System.Drawing.Point(12, 3);
            this.MouseLocation.Name = "MouseLocation";
            this.MouseLocation.Size = new System.Drawing.Size(38, 13);
            this.MouseLocation.TabIndex = 9;
            this.MouseLocation.Text = "x = y =";
            // 
            // StartXY
            // 
            this.StartXY.Location = new System.Drawing.Point(767, 35);
            this.StartXY.Name = "StartXY";
            this.StartXY.Size = new System.Drawing.Size(30, 23);
            this.StartXY.TabIndex = 10;
            this.StartXY.Text = "V";
            this.StartXY.UseVisualStyleBackColor = true;
            // 
            // paImage
            // 
            this.paImage.BackColor = System.Drawing.Color.Silver;
            this.paImage.BackgroundImage = global::labPaint.Properties.Resources.bim;
            this.paImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paImage.Location = new System.Drawing.Point(297, 348);
            this.paImage.Name = "paImage";
            this.paImage.Size = new System.Drawing.Size(200, 100);
            this.paImage.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::labPaint.Properties.Resources.bim;
            this.panel2.Location = new System.Drawing.Point(237, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 100);
            this.panel2.TabIndex = 17;
            // 
            // AllColor
            // 
            this.AllColor.BackColor = System.Drawing.Color.Transparent;
            this.AllColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllColor.Location = new System.Drawing.Point(422, 0);
            this.AllColor.Name = "AllColor";
            this.AllColor.Size = new System.Drawing.Size(30, 83);
            this.AllColor.TabIndex = 12;
            this.AllColor.TabStop = false;
            // 
            // RndColor
            // 
            this.RndColor.BackColor = System.Drawing.Color.Fuchsia;
            this.RndColor.BackgroundImage = global::labPaint.Properties.Resources.RndColor;
            this.RndColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.RndColor.Image = global::labPaint.Properties.Resources.RndColor;
            this.RndColor.Location = new System.Drawing.Point(452, 0);
            this.RndColor.Name = "RndColor";
            this.RndColor.Size = new System.Drawing.Size(30, 83);
            this.RndColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RndColor.TabIndex = 11;
            this.RndColor.TabStop = false;
            // 
            // Fuchsia
            // 
            this.Fuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.Fuchsia.Dock = System.Windows.Forms.DockStyle.Right;
            this.Fuchsia.Location = new System.Drawing.Point(482, 0);
            this.Fuchsia.Name = "Fuchsia";
            this.Fuchsia.Size = new System.Drawing.Size(30, 83);
            this.Fuchsia.TabIndex = 10;
            this.Fuchsia.TabStop = false;
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Dock = System.Windows.Forms.DockStyle.Right;
            this.Blue.Location = new System.Drawing.Point(512, 0);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(30, 83);
            this.Blue.TabIndex = 9;
            this.Blue.TabStop = false;
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Dock = System.Windows.Forms.DockStyle.Right;
            this.Aqua.Location = new System.Drawing.Point(542, 0);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(30, 83);
            this.Aqua.TabIndex = 8;
            this.Aqua.TabStop = false;
            // 
            // Lime
            // 
            this.Lime.BackColor = System.Drawing.Color.Lime;
            this.Lime.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lime.Location = new System.Drawing.Point(572, 0);
            this.Lime.Name = "Lime";
            this.Lime.Size = new System.Drawing.Size(30, 83);
            this.Lime.TabIndex = 7;
            this.Lime.TabStop = false;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Dock = System.Windows.Forms.DockStyle.Right;
            this.Yellow.Location = new System.Drawing.Point(602, 0);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(30, 83);
            this.Yellow.TabIndex = 6;
            this.Yellow.TabStop = false;
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Dock = System.Windows.Forms.DockStyle.Right;
            this.Orange.Location = new System.Drawing.Point(632, 0);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(30, 83);
            this.Orange.TabIndex = 5;
            this.Orange.TabStop = false;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Dock = System.Windows.Forms.DockStyle.Right;
            this.Red.Location = new System.Drawing.Point(662, 0);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(30, 83);
            this.Red.TabIndex = 4;
            this.Red.TabStop = false;
            // 
            // Silver
            // 
            this.Silver.BackColor = System.Drawing.Color.Silver;
            this.Silver.Dock = System.Windows.Forms.DockStyle.Right;
            this.Silver.Location = new System.Drawing.Point(692, 0);
            this.Silver.Name = "Silver";
            this.Silver.Size = new System.Drawing.Size(30, 83);
            this.Silver.TabIndex = 3;
            this.Silver.TabStop = false;
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Dock = System.Windows.Forms.DockStyle.Right;
            this.White.Location = new System.Drawing.Point(722, 0);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(30, 83);
            this.White.TabIndex = 2;
            this.White.TabStop = false;
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Dock = System.Windows.Forms.DockStyle.Right;
            this.Black.Location = new System.Drawing.Point(752, 0);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(30, 83);
            this.Black.TabIndex = 1;
            this.Black.TabStop = false;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.paImage);
            this.Controls.Add(this.StartXY);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.MouseLocation);
            this.Controls.Add(this.instpanel);
            this.Controls.Add(this.toolsBar);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "labPaint";
            this.instpanel.ResumeLayout(false);
            this.instpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sizepen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RndColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fuchsia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Silver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.White)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Black)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel instpanel;
        private System.Windows.Forms.ToolBar toolsBar;
        private System.Windows.Forms.ToolBarButton arrowBtn;
        private System.Windows.Forms.ToolBarButton lineBtn;
        private System.Windows.Forms.ToolBarButton pencilBtn;
        private System.Windows.Forms.ToolBarButton rectangleBtn;
        private System.Windows.Forms.ToolBarButton ellipseBtn;
        private System.Windows.Forms.ToolBarButton brushBtn;
        private System.Windows.Forms.ToolBarButton fillBtn;
        private System.Windows.Forms.ToolBarButton textBtn;
        private System.Windows.Forms.ToolBarButton eraserBtn;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MenuItem fileMnu;
        private System.Windows.Forms.MenuItem fileNewMnu;
        private System.Windows.Forms.MenuItem fileOpenMnu;
        private System.Windows.Forms.MenuItem fileSaveMnu;
        private System.Windows.Forms.MenuItem fileSaveAsMnu;
        private System.Windows.Forms.MenuItem sep1;
        private System.Windows.Forms.MenuItem fileExitMnu;
        private System.Windows.Forms.MenuItem editMnu;
        private System.Windows.Forms.MenuItem editCutMnu;
        private System.Windows.Forms.MenuItem editCopyMnu;
        private System.Windows.Forms.MenuItem editPasteMnu;
        private System.Windows.Forms.MenuItem imageMnu;
        private System.Windows.Forms.MenuItem imageClearMnu;
        private System.Windows.Forms.MenuItem helpMnu;
        private System.Windows.Forms.MenuItem helpAboutMnu;
        private System.Windows.Forms.Label MouseLocation;
        private System.Windows.Forms.Button StartXY;
        private System.Windows.Forms.PictureBox Fuchsia;
        private System.Windows.Forms.PictureBox Blue;
        private System.Windows.Forms.PictureBox Aqua;
        private System.Windows.Forms.PictureBox Lime;
        private System.Windows.Forms.PictureBox Yellow;
        private System.Windows.Forms.PictureBox Orange;
        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.PictureBox Silver;
        private System.Windows.Forms.PictureBox White;
        private System.Windows.Forms.PictureBox Black;
        private System.Windows.Forms.PictureBox AllColor;
        private System.Windows.Forms.PictureBox RndColor;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TrackBar Sizepen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearPanel;
        private System.Windows.Forms.Panel paImage;
        private System.Windows.Forms.Panel panel2;
    }
}

