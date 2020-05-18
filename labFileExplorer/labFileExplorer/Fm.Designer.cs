namespace labFileExplorer
{
    partial class Fm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm));
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.buBack = new System.Windows.Forms.ToolStripButton();
            this.buForward = new System.Windows.Forms.ToolStripButton();
            this.buUp = new System.Windows.Forms.ToolStripButton();
            this.edDir = new System.Windows.Forms.ToolStripTextBox();
            this.buDirSelect = new System.Windows.Forms.ToolStripButton();
            this.DButtons = new System.Windows.Forms.ToolStripDropDownButton();
            this.miViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.LV = new System.Windows.Forms.ListView();
            this.iLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.iSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.paPreview = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.paLogicalDrives = new System.Windows.Forms.Panel();
            this.toolMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.paPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolMenu
            // 
            this.toolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolMenu.AutoSize = false;
            this.toolMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buBack,
            this.buForward,
            this.buUp,
            this.edDir,
            this.buDirSelect,
            this.DButtons});
            this.toolMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolMenu.Location = new System.Drawing.Point(0, 10);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolMenu.ShowItemToolTips = false;
            this.toolMenu.Size = new System.Drawing.Size(1014, 41);
            this.toolMenu.Stretch = true;
            this.toolMenu.TabIndex = 0;
            this.toolMenu.Text = "toolStrip1";
            // 
            // buBack
            // 
            this.buBack.AutoSize = false;
            this.buBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buBack.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.buBack.ForeColor = System.Drawing.Color.Tomato;
            this.buBack.Image = ((System.Drawing.Image)(resources.GetObject("buBack.Image")));
            this.buBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(38, 32);
            this.buBack.Text = "🢀";
            // 
            // buForward
            // 
            this.buForward.AutoSize = false;
            this.buForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buForward.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.buForward.ForeColor = System.Drawing.Color.Tomato;
            this.buForward.Image = ((System.Drawing.Image)(resources.GetObject("buForward.Image")));
            this.buForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(37, 32);
            this.buForward.Text = "🡺";
            // 
            // buUp
            // 
            this.buUp.AutoSize = false;
            this.buUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buUp.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.buUp.ForeColor = System.Drawing.Color.Tomato;
            this.buUp.Image = ((System.Drawing.Image)(resources.GetObject("buUp.Image")));
            this.buUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(34, 32);
            this.buUp.Text = "🢄";
            // 
            // edDir
            // 
            this.edDir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.edDir.AutoSize = false;
            this.edDir.AutoToolTip = true;
            this.edDir.BackColor = System.Drawing.SystemColors.Control;
            this.edDir.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.edDir.ForeColor = System.Drawing.Color.Tomato;
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(800, 35);
            // 
            // buDirSelect
            // 
            this.buDirSelect.AutoSize = false;
            this.buDirSelect.BackColor = System.Drawing.Color.Transparent;
            this.buDirSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buDirSelect.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.buDirSelect.ForeColor = System.Drawing.Color.Tomato;
            this.buDirSelect.Image = ((System.Drawing.Image)(resources.GetObject("buDirSelect.Image")));
            this.buDirSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buDirSelect.Name = "buDirSelect";
            this.buDirSelect.Size = new System.Drawing.Size(38, 32);
            this.buDirSelect.Text = "...⮯";
            // 
            // DButtons
            // 
            this.DButtons.AutoSize = false;
            this.DButtons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DButtons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewLargeIcon,
            this.miViewSmallIcon,
            this.miViewList,
            this.miViewDetails,
            this.miViewTile});
            this.DButtons.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.DButtons.ForeColor = System.Drawing.Color.Tomato;
            this.DButtons.Image = ((System.Drawing.Image)(resources.GetObject("DButtons.Image")));
            this.DButtons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DButtons.Name = "DButtons";
            this.DButtons.Size = new System.Drawing.Size(63, 32);
            this.DButtons.Text = "Вид";
            // 
            // miViewLargeIcon
            // 
            this.miViewLargeIcon.ForeColor = System.Drawing.Color.Tomato;
            this.miViewLargeIcon.Name = "miViewLargeIcon";
            this.miViewLargeIcon.Size = new System.Drawing.Size(179, 32);
            this.miViewLargeIcon.Text = "LargeIcon";
            // 
            // miViewSmallIcon
            // 
            this.miViewSmallIcon.ForeColor = System.Drawing.Color.Tomato;
            this.miViewSmallIcon.Name = "miViewSmallIcon";
            this.miViewSmallIcon.Size = new System.Drawing.Size(179, 32);
            this.miViewSmallIcon.Text = "SmallIcon";
            // 
            // miViewList
            // 
            this.miViewList.ForeColor = System.Drawing.Color.Tomato;
            this.miViewList.Name = "miViewList";
            this.miViewList.Size = new System.Drawing.Size(179, 32);
            this.miViewList.Text = "List";
            // 
            // miViewDetails
            // 
            this.miViewDetails.ForeColor = System.Drawing.Color.Tomato;
            this.miViewDetails.Name = "miViewDetails";
            this.miViewDetails.Size = new System.Drawing.Size(179, 32);
            this.miViewDetails.Text = "Details";
            // 
            // miViewTile
            // 
            this.miViewTile.ForeColor = System.Drawing.Color.Tomato;
            this.miViewTile.Name = "miViewTile";
            this.miViewTile.Size = new System.Drawing.Size(179, 32);
            this.miViewTile.Text = "Tile";
            // 
            // LV
            // 
            this.LV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV.BackColor = System.Drawing.SystemColors.Control;
            this.LV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LV.ForeColor = System.Drawing.Color.LightCoral;
            this.LV.HideSelection = false;
            this.LV.LargeImageList = this.iLargeIcons;
            this.LV.Location = new System.Drawing.Point(1, 116);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(1035, 663);
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
            this.iLargeIcons.Images.SetKeyName(2, "Image-1_240.png");
            this.iLargeIcons.Images.SetKeyName(3, "Film-Roll_240.png");
            this.iLargeIcons.Images.SetKeyName(4, "Music-Note 1_240.png");
            this.iLargeIcons.Images.SetKeyName(5, "Box-2_240.png");
            this.iLargeIcons.Images.SetKeyName(6, "Edit-Note 2_240.png");
            this.iLargeIcons.Images.SetKeyName(7, "Processor-1_240.png");
            this.iLargeIcons.Images.SetKeyName(8, "Gear-2_240.png");
            this.iLargeIcons.Images.SetKeyName(9, "Barcode-Scann_240.png");
            // 
            // iSmallIcons
            // 
            this.iSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iSmallIcons.ImageStream")));
            this.iSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.iSmallIcons.Images.SetKeyName(0, "799655_folder_512x512.png");
            this.iSmallIcons.Images.SetKeyName(1, "75_-Folder_Content-_document_paper_write_note-128.png");
            this.iSmallIcons.Images.SetKeyName(2, "Image-1_240.png");
            this.iSmallIcons.Images.SetKeyName(3, "Film-Roll_240.png");
            this.iSmallIcons.Images.SetKeyName(4, "Music-Note 1_240.png");
            this.iSmallIcons.Images.SetKeyName(5, "Box-2_240.png");
            this.iSmallIcons.Images.SetKeyName(6, "Edit-Note 2_240.png");
            this.iSmallIcons.Images.SetKeyName(7, "Processor-1_240.png");
            this.iSmallIcons.Images.SetKeyName(8, "Gear-2_240.png");
            this.iSmallIcons.Images.SetKeyName(9, "Barcode-Scann_240.png");
            this.iSmallIcons.Images.SetKeyName(10, "75_-Folder_Content-_document_paper_write_note-128.png");
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.toolMenu);
            this.panelMenu.Location = new System.Drawing.Point(2, 59);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1034, 51);
            this.panelMenu.TabIndex = 2;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.la);
            this.panelInfo.Location = new System.Drawing.Point(1042, 550);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(386, 229);
            this.panelInfo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(16, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата изменения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(16, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата создания";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Путь";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Расширение";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Значение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // la
            // 
            this.la.BackColor = System.Drawing.Color.Transparent;
            this.la.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la.ForeColor = System.Drawing.Color.Tomato;
            this.la.Location = new System.Drawing.Point(3, 9);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(173, 38);
            this.la.TabIndex = 4;
            this.la.Text = "Свойство";
            this.la.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.la.UseMnemonic = false;
            // 
            // paPreview
            // 
            this.paPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paPreview.BackColor = System.Drawing.Color.Transparent;
            this.paPreview.Controls.Add(this.label8);
            this.paPreview.Location = new System.Drawing.Point(1042, 59);
            this.paPreview.Name = "paPreview";
            this.paPreview.Size = new System.Drawing.Size(395, 485);
            this.paPreview.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // paLogicalDrives
            // 
            this.paLogicalDrives.BackColor = System.Drawing.Color.Transparent;
            this.paLogicalDrives.Location = new System.Drawing.Point(159, 25);
            this.paLogicalDrives.Name = "paLogicalDrives";
            this.paLogicalDrives.Size = new System.Drawing.Size(877, 39);
            this.paLogicalDrives.TabIndex = 5;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.paLogicalDrives);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.paPreview);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.LV);
            this.Name = "Fm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "labFileExplorer";
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.paPreview.ResumeLayout(false);
            this.paPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton buForward;
        private System.Windows.Forms.ToolStripButton buUp;
        private System.Windows.Forms.ToolStripTextBox edDir;
        private System.Windows.Forms.ToolStripButton buDirSelect;
        private System.Windows.Forms.ToolStripDropDownButton DButtons;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.ToolStripMenuItem miViewLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem miViewSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem miViewList;
        private System.Windows.Forms.ToolStripMenuItem miViewDetails;
        private System.Windows.Forms.ToolStripMenuItem miViewTile;
        private System.Windows.Forms.ImageList iLargeIcons;
        private System.Windows.Forms.ImageList iSmallIcons;
        public System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paPreview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton buBack;
        private System.Windows.Forms.Panel paLogicalDrives;
    }
}

