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
            this.laTags = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.toolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // edTags
            // 
            this.edTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTags.BackColor = System.Drawing.SystemColors.Control;
            this.edTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edTags.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.edTags.ForeColor = System.Drawing.Color.LightCoral;
            this.edTags.Location = new System.Drawing.Point(0, 97);
            this.edTags.Multiline = true;
            this.edTags.Name = "edTags";
            this.edTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edTags.Size = new System.Drawing.Size(791, 670);
            this.edTags.TabIndex = 0;
            this.edTags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.edDir.ReadOnly = true;
            this.edDir.Size = new System.Drawing.Size(400, 35);
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
            // laTags
            // 
            this.laTags.BackColor = System.Drawing.Color.Transparent;
            this.laTags.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laTags.ForeColor = System.Drawing.Color.Tomato;
            this.laTags.Location = new System.Drawing.Point(3, 35);
            this.laTags.Name = "laTags";
            this.laTags.Size = new System.Drawing.Size(431, 38);
            this.laTags.TabIndex = 5;
            this.laTags.Text = "Найдено Tag\'ов - ";
            this.laTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laTags.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(423, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Есть ограничения на максимальное кол-во, иначе зависает))\r\nЕсли где-то есть .exe " +
    "и т.п, это не расширение, а имя..\r\nФильтр Count > 1\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 767);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laTags);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.edTags);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "Fm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label laTags;
        private System.Windows.Forms.Label label1;
    }
}

