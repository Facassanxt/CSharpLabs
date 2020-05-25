namespace labSearchCity
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
            this.edSearch = new System.Windows.Forms.TextBox();
            this.laCount = new System.Windows.Forms.Label();
            this.edResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.edSearch.Location = new System.Drawing.Point(12, 37);
            this.edSearch.Name = "textBox1";
            this.edSearch.Size = new System.Drawing.Size(776, 20);
            this.edSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.laCount.AutoSize = true;
            this.laCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.laCount.Location = new System.Drawing.Point(12, 60);
            this.laCount.Name = "label1";
            this.laCount.Size = new System.Drawing.Size(86, 31);
            this.laCount.TabIndex = 1;
            this.laCount.Text = "label1";
            // 
            // textBox2
            // 
            this.edResult.Location = new System.Drawing.Point(3, 101);
            this.edResult.Multiline = true;
            this.edResult.Name = "textBox2";
            this.edResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edResult.Size = new System.Drawing.Size(796, 345);
            this.edResult.TabIndex = 2;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edResult);
            this.Controls.Add(this.laCount);
            this.Controls.Add(this.edSearch);
            this.Name = "Fm";
            this.Text = "labSearchCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edSearch;
        private System.Windows.Forms.Label laCount;
        private System.Windows.Forms.TextBox edResult;
    }
}

