namespace labMediaPlayer
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
            this.buPlay = new System.Windows.Forms.Button();
            this.buPause = new System.Windows.Forms.Button();
            this.buStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buPlay.Location = new System.Drawing.Point(177, 90);
            this.buPlay.Name = "button1";
            this.buPlay.Size = new System.Drawing.Size(75, 23);
            this.buPlay.TabIndex = 0;
            this.buPlay.Text = "button1";
            this.buPlay.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buPause.Location = new System.Drawing.Point(258, 90);
            this.buPause.Name = "button2";
            this.buPause.Size = new System.Drawing.Size(75, 23);
            this.buPause.TabIndex = 1;
            this.buPause.Text = "button2";
            this.buPause.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.buStop.Location = new System.Drawing.Point(339, 90);
            this.buStop.Name = "button3";
            this.buStop.Size = new System.Drawing.Size(75, 23);
            this.buStop.TabIndex = 2;
            this.buStop.Text = "button3";
            this.buStop.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // trackBar1
            // 
            this.trVolume.Location = new System.Drawing.Point(133, 144);
            this.trVolume.Name = "trackBar1";
            this.trVolume.Size = new System.Drawing.Size(364, 45);
            this.trVolume.TabIndex = 4;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buStop);
            this.Controls.Add(this.buPause);
            this.Controls.Add(this.buPlay);
            this.Name = "Fm";
            this.Text = "labMediaPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.trVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buPlay;
        private System.Windows.Forms.Button buPause;
        private System.Windows.Forms.Button buStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trVolume;
    }
}

