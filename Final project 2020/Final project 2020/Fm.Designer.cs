namespace Final_project_2020
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buReset = new System.Windows.Forms.Button();
            this.buPlay = new System.Windows.Forms.Button();
            this.buStop = new System.Windows.Forms.Button();
            this.gameScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 500;
            // 
            // buReset
            // 
            this.buReset.AutoSize = true;
            this.buReset.BackColor = System.Drawing.Color.Transparent;
            this.buReset.FlatAppearance.BorderSize = 0;
            this.buReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buReset.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buReset.ForeColor = System.Drawing.Color.Coral;
            this.buReset.Location = new System.Drawing.Point(229, 29);
            this.buReset.Name = "buReset";
            this.buReset.Size = new System.Drawing.Size(121, 39);
            this.buReset.TabIndex = 36;
            this.buReset.Text = "Reset";
            this.buReset.UseVisualStyleBackColor = false;
            // 
            // buPlay
            // 
            this.buPlay.AutoSize = true;
            this.buPlay.BackColor = System.Drawing.Color.Transparent;
            this.buPlay.FlatAppearance.BorderSize = 0;
            this.buPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buPlay.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buPlay.ForeColor = System.Drawing.Color.Coral;
            this.buPlay.Location = new System.Drawing.Point(338, 29);
            this.buPlay.Name = "buPlay";
            this.buPlay.Size = new System.Drawing.Size(121, 39);
            this.buPlay.TabIndex = 37;
            this.buPlay.Text = "Play";
            this.buPlay.UseVisualStyleBackColor = false;
            // 
            // buStop
            // 
            this.buStop.AutoSize = true;
            this.buStop.BackColor = System.Drawing.Color.Transparent;
            this.buStop.FlatAppearance.BorderSize = 0;
            this.buStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buStop.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buStop.ForeColor = System.Drawing.Color.Coral;
            this.buStop.Location = new System.Drawing.Point(465, 29);
            this.buStop.Name = "buStop";
            this.buStop.Size = new System.Drawing.Size(121, 39);
            this.buStop.TabIndex = 38;
            this.buStop.Text = "Stop";
            this.buStop.UseVisualStyleBackColor = false;
            // 
            // gameScreen
            // 
            this.gameScreen.Location = new System.Drawing.Point(1, 62);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1197, 784);
            this.gameScreen.TabIndex = 39;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 898);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.buStop);
            this.Controls.Add(this.buPlay);
            this.Controls.Add(this.buReset);
            this.Name = "Fm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOfLife";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buReset;
        private System.Windows.Forms.Button buPlay;
        private System.Windows.Forms.Button buStop;
        private System.Windows.Forms.Panel gameScreen;
    }
}

