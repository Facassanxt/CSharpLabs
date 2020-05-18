namespace labFileExplorerOnWB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buBack = new System.Windows.Forms.Button();
            this.buForward = new System.Windows.Forms.Button();
            this.buUp = new System.Windows.Forms.Button();
            this.BuDirSelect = new System.Windows.Forms.Button();
            this.edDir = new System.Windows.Forms.TextBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edDir);
            this.panel1.Controls.Add(this.BuDirSelect);
            this.panel1.Controls.Add(this.buUp);
            this.panel1.Controls.Add(this.buForward);
            this.panel1.Controls.Add(this.buBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 55);
            this.panel1.TabIndex = 0;
            // 
            // buBack
            // 
            this.buBack.AutoSize = true;
            this.buBack.Location = new System.Drawing.Point(12, 12);
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(75, 25);
            this.buBack.TabIndex = 0;
            this.buBack.Text = "◀";
            this.buBack.UseVisualStyleBackColor = true;
            // 
            // buForward
            // 
            this.buForward.AutoSize = true;
            this.buForward.Location = new System.Drawing.Point(93, 12);
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(75, 23);
            this.buForward.TabIndex = 1;
            this.buForward.Text = "▶";
            this.buForward.UseVisualStyleBackColor = true;
            // 
            // buUp
            // 
            this.buUp.AutoSize = true;
            this.buUp.Location = new System.Drawing.Point(174, 12);
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(75, 23);
            this.buUp.TabIndex = 2;
            this.buUp.Text = "▲";
            this.buUp.UseVisualStyleBackColor = true;
            // 
            // BuDirSelect
            // 
            this.BuDirSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuDirSelect.Location = new System.Drawing.Point(649, 15);
            this.BuDirSelect.Name = "BuDirSelect";
            this.BuDirSelect.Size = new System.Drawing.Size(75, 23);
            this.BuDirSelect.TabIndex = 3;
            this.BuDirSelect.Text = "...";
            this.BuDirSelect.UseVisualStyleBackColor = true;
            // 
            // edDir
            // 
            this.edDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edDir.Location = new System.Drawing.Point(255, 15);
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(388, 20);
            this.edDir.TabIndex = 4;
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(0, 55);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(732, 395);
            this.wb.TabIndex = 1;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.panel1);
            this.Name = "fm";
            this.Text = "labFileExplorerOnWB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox edDir;
        private System.Windows.Forms.Button BuDirSelect;
        private System.Windows.Forms.Button buUp;
        private System.Windows.Forms.Button buForward;
        private System.Windows.Forms.Button buBack;
        private System.Windows.Forms.WebBrowser wb;
    }
}

