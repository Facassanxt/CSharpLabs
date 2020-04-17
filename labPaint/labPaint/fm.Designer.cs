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
            this.pamenu = new System.Windows.Forms.Panel();
            this.paImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pamenu
            // 
            this.pamenu.Location = new System.Drawing.Point(12, 12);
            this.pamenu.Name = "pamenu";
            this.pamenu.Size = new System.Drawing.Size(168, 426);
            this.pamenu.TabIndex = 0;
            // 
            // paImage
            // 
            this.paImage.Location = new System.Drawing.Point(186, 12);
            this.paImage.Name = "paImage";
            this.paImage.Size = new System.Drawing.Size(611, 426);
            this.paImage.TabIndex = 1;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paImage);
            this.Controls.Add(this.pamenu);
            this.Name = "fm";
            this.Text = "labPaint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pamenu;
        private System.Windows.Forms.Panel paImage;
    }
}

