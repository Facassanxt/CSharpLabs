namespace labFileExplorer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buBack = new System.Windows.Forms.ToolStripButton();
            this.buForward = new System.Windows.Forms.ToolStripButton();
            this.buUp = new System.Windows.Forms.ToolStripButton();
            this.edDir = new System.Windows.Forms.ToolStripTextBox();
            this.buDirSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.LV = new System.Windows.Forms.ListView();
            this.iLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.iSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buBack,
            this.buForward,
            this.buUp,
            this.edDir,
            this.buDirSelect,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buBack
            // 
            this.buBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buBack.Image = ((System.Drawing.Image)(resources.GetObject("buBack.Image")));
            this.buBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(23, 22);
            this.buBack.Text = "◀";
            // 
            // buForward
            // 
            this.buForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buForward.Image = ((System.Drawing.Image)(resources.GetObject("buForward.Image")));
            this.buForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(23, 22);
            this.buForward.Text = "▶";
            // 
            // buUp
            // 
            this.buUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buUp.Image = ((System.Drawing.Image)(resources.GetObject("buUp.Image")));
            this.buUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(23, 22);
            this.buUp.Text = "▲";
            // 
            // edDir
            // 
            this.edDir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(450, 25);
            // 
            // buDirSelect
            // 
            this.buDirSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buDirSelect.Image = ((System.Drawing.Image)(resources.GetObject("buDirSelect.Image")));
            this.buDirSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buDirSelect.Name = "buDirSelect";
            this.buDirSelect.Size = new System.Drawing.Size(23, 22);
            this.buDirSelect.Text = "...";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewLargeIcon,
            this.miViewSmallIcon,
            this.miViewList,
            this.miViewDetails,
            this.miViewTile});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton1.Text = "Вид";
            // 
            // miViewLargeIcon
            // 
            this.miViewLargeIcon.Name = "miViewLargeIcon";
            this.miViewLargeIcon.Size = new System.Drawing.Size(180, 22);
            this.miViewLargeIcon.Text = "LargeIcon";
            // 
            // miViewSmallIcon
            // 
            this.miViewSmallIcon.Name = "miViewSmallIcon";
            this.miViewSmallIcon.Size = new System.Drawing.Size(180, 22);
            this.miViewSmallIcon.Text = "SmallIcon";
            // 
            // miViewList
            // 
            this.miViewList.Name = "miViewList";
            this.miViewList.Size = new System.Drawing.Size(180, 22);
            this.miViewList.Text = "List";
            // 
            // miViewDetails
            // 
            this.miViewDetails.Name = "miViewDetails";
            this.miViewDetails.Size = new System.Drawing.Size(180, 22);
            this.miViewDetails.Text = "Details";
            // 
            // miViewTile
            // 
            this.miViewTile.Name = "miViewTile";
            this.miViewTile.Size = new System.Drawing.Size(180, 22);
            this.miViewTile.Text = "Tile";
            // 
            // LV
            // 
            this.LV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV.HideSelection = false;
            this.LV.LargeImageList = this.iLargeIcons;
            this.LV.Location = new System.Drawing.Point(0, 25);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(800, 425);
            this.LV.SmallImageList = this.iSmallIcons;
            this.LV.TabIndex = 1;
            this.LV.UseCompatibleStateImageBehavior = false;
            // 
            // iLargeIcons
            // 
            this.iLargeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLargeIcons.ImageStream")));
            this.iLargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.iLargeIcons.Images.SetKeyName(0, "799655_folder_512x512.png");
            this.iLargeIcons.Images.SetKeyName(1, "75_-Folder_Content-_document_paper_write_note-128.png");
            // 
            // iSmallIcons
            // 
            this.iSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iSmallIcons.ImageStream")));
            this.iSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.iSmallIcons.Images.SetKeyName(0, "799655_folder_512x512.png");
            this.iSmallIcons.Images.SetKeyName(1, "75_-Folder_Content-_document_paper_write_note-128.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "labFileExplorer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buBack;
        private System.Windows.Forms.ToolStripButton buForward;
        private System.Windows.Forms.ToolStripButton buUp;
        private System.Windows.Forms.ToolStripTextBox edDir;
        private System.Windows.Forms.ToolStripButton buDirSelect;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.ToolStripMenuItem miViewLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem miViewSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem miViewList;
        private System.Windows.Forms.ToolStripMenuItem miViewDetails;
        private System.Windows.Forms.ToolStripMenuItem miViewTile;
        private System.Windows.Forms.ImageList iLargeIcons;
        private System.Windows.Forms.ImageList iSmallIcons;
    }
}

