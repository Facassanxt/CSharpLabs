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
            this.paImage = new System.Windows.Forms.Panel();
            this.instpanel = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.instpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // paImage
            // 
            this.paImage.Location = new System.Drawing.Point(178, 280);
            this.paImage.Name = "paImage";
            this.paImage.Size = new System.Drawing.Size(149, 108);
            this.paImage.TabIndex = 1;
            // 
            // instpanel
            // 
            this.instpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.instpanel.Controls.Add(this.label1);
            this.instpanel.Location = new System.Drawing.Point(41, 85);
            this.instpanel.Name = "instpanel";
            this.instpanel.Size = new System.Drawing.Size(390, 53);
            this.instpanel.TabIndex = 8;
            // 
            // toolsBar
            // 
            this.toolsBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolsBar.AutoSize = false;
            this.toolsBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.arrowBtn,
            this.lineBtn,
            this.pencilBtn,
            this.rectangleBtn,
            this.ellipseBtn,
            this.brushBtn,
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
            this.arrowBtn.ImageIndex = 8;
            this.arrowBtn.Name = "arrowBtn";
            this.arrowBtn.Pushed = true;
            // 
            // lineBtn
            // 
            this.lineBtn.ImageIndex = 0;
            this.lineBtn.Name = "lineBtn";
            // 
            // pencilBtn
            // 
            this.pencilBtn.ImageIndex = 2;
            this.pencilBtn.Name = "pencilBtn";
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.ImageIndex = 1;
            this.rectangleBtn.Name = "rectangleBtn";
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.ImageIndex = 4;
            this.ellipseBtn.Name = "ellipseBtn";
            // 
            // brushBtn
            // 
            this.brushBtn.ImageIndex = 3;
            this.brushBtn.Name = "brushBtn";
            // 
            // fillBtn
            // 
            this.fillBtn.ImageIndex = 7;
            this.fillBtn.Name = "fillBtn";
            // 
            // textBtn
            // 
            this.textBtn.ImageIndex = 5;
            this.textBtn.Name = "textBtn";
            // 
            // eraserBtn
            // 
            this.eraserBtn.ImageIndex = 6;
            this.eraserBtn.Name = "eraserBtn";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.MouseLocation);
            this.Controls.Add(this.paImage);
            this.Controls.Add(this.instpanel);
            this.Controls.Add(this.toolsBar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "labPaint";
            this.instpanel.ResumeLayout(false);
            this.instpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel paImage;
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
        private System.Windows.Forms.Label label1;
    }
}

