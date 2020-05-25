namespace labDirToTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm));
            this.edTags = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.edDir = new System.Windows.Forms.ToolStripTextBox();
            this.buDirSelect = new System.Windows.Forms.ToolStripButton();
            this.panelMenu.SuspendLayout();
            this.toolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // edTags
            // 
            this.edTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTags.BackColor = System.Drawing.SystemColors.Control;
            this.edTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edTags.Location = new System.Drawing.Point(9, 47);
            this.edTags.Multiline = true;
            this.edTags.Name = "edTags";
            this.edTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edTags.Size = new System.Drawing.Size(776, 403);
            this.edTags.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.Controls.Add(this.toolMenu);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 41);
            this.panelMenu.TabIndex = 3;
            // 
            // toolMenu
            // 
            this.toolMenu.AutoSize = false;
            this.toolMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edDir,
            this.buDirSelect});
            this.toolMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolMenu.ShowItemToolTips = false;
            this.toolMenu.Size = new System.Drawing.Size(791, 35);
            this.toolMenu.Stretch = true;
            this.toolMenu.TabIndex = 0;
            this.toolMenu.Text = "toolStrip1";
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
            this.edDir.Size = new System.Drawing.Size(750, 35);
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
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.edTags);
            this.Name = "Fm";
            this.Text = "labDirToTags";
            this.panelMenu.ResumeLayout(false);
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edTags;
        private System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripTextBox edDir;
        private System.Windows.Forms.ToolStripButton buDirSelect;
    }
}

