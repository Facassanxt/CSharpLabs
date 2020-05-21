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
            this.edSearch = new System.Windows.Forms.ToolStripTextBox();
            this.LV = new System.Windows.Forms.ListView();
            this.iLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.iSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.laProperty = new System.Windows.Forms.Label();
            this.paLogicalDrives = new System.Windows.Forms.Panel();
            this.laDetailsName = new System.Windows.Forms.Label();
            this.laDetailsDate = new System.Windows.Forms.Label();
            this.paDetails = new System.Windows.Forms.Panel();
            this.labDetailsSize = new System.Windows.Forms.Label();
            this.laDetailsType = new System.Windows.Forms.Label();
            this.paPreview = new System.Windows.Forms.Panel();
            this.cbInfo = new System.Windows.Forms.CheckBox();
            this.toolMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.paDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolMenu
            // 
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
            this.DButtons,
            this.edSearch});
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
            this.edDir.Size = new System.Drawing.Size(600, 35);
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
            // edSearch
            // 
            this.edSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.edSearch.AutoSize = false;
            this.edSearch.AutoToolTip = true;
            this.edSearch.BackColor = System.Drawing.SystemColors.Control;
            this.edSearch.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.edSearch.ForeColor = System.Drawing.Color.RosyBrown;
            this.edSearch.Name = "edSearch";
            this.edSearch.Size = new System.Drawing.Size(150, 35);
            this.edSearch.Text = "Поиск: *.*";
            this.edSearch.ToolTipText = "\r\n";
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
            this.LV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LV.HideSelection = false;
            this.LV.LargeImageList = this.iLargeIcons;
            this.LV.Location = new System.Drawing.Point(2, 152);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(1044, 795);
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
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.laProperty);
            this.panelInfo.Location = new System.Drawing.Point(1050, 392);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(338, 461);
            this.panelInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(215, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Значение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // laProperty
            // 
            this.laProperty.BackColor = System.Drawing.Color.Transparent;
            this.laProperty.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laProperty.ForeColor = System.Drawing.Color.Tomato;
            this.laProperty.Location = new System.Drawing.Point(0, 0);
            this.laProperty.Name = "laProperty";
            this.laProperty.Size = new System.Drawing.Size(173, 38);
            this.laProperty.TabIndex = 4;
            this.laProperty.Text = "Свойство";
            this.laProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laProperty.UseMnemonic = false;
            // 
            // paLogicalDrives
            // 
            this.paLogicalDrives.BackColor = System.Drawing.Color.Transparent;
            this.paLogicalDrives.Location = new System.Drawing.Point(159, 25);
            this.paLogicalDrives.Name = "paLogicalDrives";
            this.paLogicalDrives.Size = new System.Drawing.Size(877, 39);
            this.paLogicalDrives.TabIndex = 5;
            // 
            // laDetailsName
            // 
            this.laDetailsName.AutoSize = true;
            this.laDetailsName.BackColor = System.Drawing.Color.Transparent;
            this.laDetailsName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laDetailsName.ForeColor = System.Drawing.Color.Firebrick;
            this.laDetailsName.Location = new System.Drawing.Point(14, 0);
            this.laDetailsName.Name = "laDetailsName";
            this.laDetailsName.Size = new System.Drawing.Size(50, 26);
            this.laDetailsName.TabIndex = 12;
            this.laDetailsName.Text = "Имя";
            this.laDetailsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laDetailsName.UseMnemonic = false;
            // 
            // laDetailsDate
            // 
            this.laDetailsDate.AutoSize = true;
            this.laDetailsDate.BackColor = System.Drawing.Color.Transparent;
            this.laDetailsDate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laDetailsDate.ForeColor = System.Drawing.Color.Firebrick;
            this.laDetailsDate.Location = new System.Drawing.Point(75, 0);
            this.laDetailsDate.Name = "laDetailsDate";
            this.laDetailsDate.Size = new System.Drawing.Size(56, 26);
            this.laDetailsDate.TabIndex = 12;
            this.laDetailsDate.Text = "Дата";
            this.laDetailsDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laDetailsDate.UseMnemonic = false;
            // 
            // paDetails
            // 
            this.paDetails.Controls.Add(this.labDetailsSize);
            this.paDetails.Controls.Add(this.laDetailsType);
            this.paDetails.Controls.Add(this.laDetailsName);
            this.paDetails.Controls.Add(this.laDetailsDate);
            this.paDetails.Location = new System.Drawing.Point(12, 113);
            this.paDetails.Name = "paDetails";
            this.paDetails.Size = new System.Drawing.Size(1021, 33);
            this.paDetails.TabIndex = 13;
            // 
            // labDetailsSize
            // 
            this.labDetailsSize.AutoSize = true;
            this.labDetailsSize.BackColor = System.Drawing.Color.Transparent;
            this.labDetailsSize.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDetailsSize.ForeColor = System.Drawing.Color.Firebrick;
            this.labDetailsSize.Location = new System.Drawing.Point(300, 0);
            this.labDetailsSize.Name = "labDetailsSize";
            this.labDetailsSize.Size = new System.Drawing.Size(74, 26);
            this.labDetailsSize.TabIndex = 13;
            this.labDetailsSize.Text = "Размер";
            this.labDetailsSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labDetailsSize.UseMnemonic = false;
            // 
            // laDetailsType
            // 
            this.laDetailsType.AutoSize = true;
            this.laDetailsType.BackColor = System.Drawing.Color.Transparent;
            this.laDetailsType.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laDetailsType.ForeColor = System.Drawing.Color.Firebrick;
            this.laDetailsType.Location = new System.Drawing.Point(244, 0);
            this.laDetailsType.Name = "laDetailsType";
            this.laDetailsType.Size = new System.Drawing.Size(49, 26);
            this.laDetailsType.TabIndex = 12;
            this.laDetailsType.Text = "Тип";
            this.laDetailsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laDetailsType.UseMnemonic = false;
            // 
            // paPreview
            // 
            this.paPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paPreview.BackColor = System.Drawing.Color.Transparent;
            this.paPreview.Location = new System.Drawing.Point(1050, 69);
            this.paPreview.Name = "paPreview";
            this.paPreview.Size = new System.Drawing.Size(350, 320);
            this.paPreview.TabIndex = 4;
            this.paPreview.Visible = false;
            // 
            // cbInfo
            // 
            this.cbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInfo.AutoSize = true;
            this.cbInfo.BackColor = System.Drawing.Color.Transparent;
            this.cbInfo.FlatAppearance.BorderSize = 0;
            this.cbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInfo.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.cbInfo.ForeColor = System.Drawing.Color.Tomato;
            this.cbInfo.Location = new System.Drawing.Point(1102, 26);
            this.cbInfo.Name = "cbInfo";
            this.cbInfo.Size = new System.Drawing.Size(298, 37);
            this.cbInfo.TabIndex = 15;
            this.cbInfo.Text = "Скрыть панель Свойств";
            this.cbInfo.UseVisualStyleBackColor = false;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 950);
            this.Controls.Add(this.cbInfo);
            this.Controls.Add(this.paDetails);
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
            this.paDetails.ResumeLayout(false);
            this.paDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label laProperty;
        private System.Windows.Forms.ToolStripButton buBack;
        private System.Windows.Forms.Panel paLogicalDrives;
        private System.Windows.Forms.Label laDetailsName;
        private System.Windows.Forms.Label laDetailsDate;
        private System.Windows.Forms.Panel paDetails;
        private System.Windows.Forms.Label labDetailsSize;
        private System.Windows.Forms.Label laDetailsType;
        private System.Windows.Forms.Panel paPreview;
        private System.Windows.Forms.ToolStripTextBox edSearch;
        private System.Windows.Forms.CheckBox cbInfo;
    }
}

