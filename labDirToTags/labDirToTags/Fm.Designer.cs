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
            this.edTags = new System.Windows.Forms.TextBox();
            this.edDir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edTags
            // 
            this.edTags.Location = new System.Drawing.Point(12, 78);
            this.edTags.Multiline = true;
            this.edTags.Name = "edTags";
            this.edTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edTags.Size = new System.Drawing.Size(776, 360);
            this.edTags.TabIndex = 0;
            // 
            // edDir
            // 
            this.edDir.Location = new System.Drawing.Point(12, 28);
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(567, 20);
            this.edDir.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edDir);
            this.Controls.Add(this.edTags);
            this.Name = "Fm";
            this.Text = "labDirToTags";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edTags;
        private System.Windows.Forms.TextBox edDir;
        private System.Windows.Forms.Button button1;
    }
}

