namespace labSoundPlayer
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
            this.buPlay = new System.Windows.Forms.Button();
            this.buStop = new System.Windows.Forms.Button();
            this.buPlayLooping = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buPlay
            // 
            this.buPlay.Location = new System.Drawing.Point(54, 50);
            this.buPlay.Name = "buPlay";
            this.buPlay.Size = new System.Drawing.Size(93, 50);
            this.buPlay.TabIndex = 0;
            this.buPlay.Text = "Play";
            this.buPlay.UseVisualStyleBackColor = true;
            // 
            // buStop
            // 
            this.buStop.Location = new System.Drawing.Point(153, 50);
            this.buStop.Name = "buStop";
            this.buStop.Size = new System.Drawing.Size(93, 50);
            this.buStop.TabIndex = 1;
            this.buStop.Text = "Stop";
            this.buStop.UseVisualStyleBackColor = true;
            // 
            // buPlayLooping
            // 
            this.buPlayLooping.Location = new System.Drawing.Point(252, 50);
            this.buPlayLooping.Name = "buPlayLooping";
            this.buPlayLooping.Size = new System.Drawing.Size(93, 50);
            this.buPlayLooping.TabIndex = 2;
            this.buPlayLooping.Text = "PlayLooping";
            this.buPlayLooping.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buPlayLooping);
            this.Controls.Add(this.buStop);
            this.Controls.Add(this.buPlay);
            this.Name = "fm";
            this.Text = "labSoundPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buPlay;
        private System.Windows.Forms.Button buStop;
        private System.Windows.Forms.Button buPlayLooping;
        private System.Windows.Forms.Button button4;
    }
}

