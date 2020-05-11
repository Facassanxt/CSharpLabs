namespace labFormTransparency
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
            this.buClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buClose
            // 
            this.buClose.AutoSize = true;
            this.buClose.BackColor = System.Drawing.Color.Transparent;
            this.buClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buClose.Location = new System.Drawing.Point(245, 440);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(41, 37);
            this.buClose.TabIndex = 0;
            this.buClose.Text = "X";
            this.buClose.UseVisualStyleBackColor = false;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::labFormTransparency.Properties.Resources.sticker_vk_mandalorec_malysh_008;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(540, 535);
            this.Controls.Add(this.buClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm";
            this.Text = "labFormTransparency";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buClose;
    }
}

