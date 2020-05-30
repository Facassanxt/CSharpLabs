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
            this.buRnd = new System.Windows.Forms.Button();
            this.buInfo = new System.Windows.Forms.Button();
            this.buRR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 50;
            // 
            // buReset
            // 
            this.buReset.AutoSize = true;
            this.buReset.BackColor = System.Drawing.Color.Transparent;
            this.buReset.FlatAppearance.BorderSize = 0;
            this.buReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buReset.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buReset.ForeColor = System.Drawing.Color.Coral;
            this.buReset.Location = new System.Drawing.Point(315, 26);
            this.buReset.Name = "buReset";
            this.buReset.Size = new System.Drawing.Size(98, 39);
            this.buReset.TabIndex = 36;
            this.buReset.Text = "Рестарт";
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
            this.buPlay.Location = new System.Drawing.Point(153, 26);
            this.buPlay.Name = "buPlay";
            this.buPlay.Size = new System.Drawing.Size(78, 39);
            this.buPlay.TabIndex = 37;
            this.buPlay.Text = "Старт";
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
            this.buStop.Location = new System.Drawing.Point(237, 26);
            this.buStop.Name = "buStop";
            this.buStop.Size = new System.Drawing.Size(72, 39);
            this.buStop.TabIndex = 38;
            this.buStop.Text = "Стоп";
            this.buStop.UseVisualStyleBackColor = false;
            // 
            // gameScreen
            // 
            this.gameScreen.Location = new System.Drawing.Point(1, 62);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1197, 784);
            this.gameScreen.TabIndex = 39;
            // 
            // buRnd
            // 
            this.buRnd.AutoSize = true;
            this.buRnd.BackColor = System.Drawing.Color.Transparent;
            this.buRnd.FlatAppearance.BorderSize = 0;
            this.buRnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buRnd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buRnd.ForeColor = System.Drawing.Color.Coral;
            this.buRnd.Location = new System.Drawing.Point(597, 26);
            this.buRnd.Name = "buRnd";
            this.buRnd.Size = new System.Drawing.Size(96, 39);
            this.buRnd.TabIndex = 37;
            this.buRnd.Text = "Рандом";
            this.buRnd.UseVisualStyleBackColor = false;
            // 
            // buInfo
            // 
            this.buInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buInfo.AutoSize = true;
            this.buInfo.BackColor = System.Drawing.Color.Transparent;
            this.buInfo.FlatAppearance.BorderSize = 0;
            this.buInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buInfo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buInfo.ForeColor = System.Drawing.Color.Coral;
            this.buInfo.Location = new System.Drawing.Point(1025, 26);
            this.buInfo.Name = "buInfo";
            this.buInfo.Size = new System.Drawing.Size(173, 39);
            this.buInfo.TabIndex = 40;
            this.buInfo.Text = "Что это такое!?";
            this.buInfo.UseVisualStyleBackColor = false;
            // 
            // buRR
            // 
            this.buRR.AutoSize = true;
            this.buRR.BackColor = System.Drawing.Color.Transparent;
            this.buRR.FlatAppearance.BorderSize = 0;
            this.buRR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buRR.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buRR.ForeColor = System.Drawing.Color.Coral;
            this.buRR.Location = new System.Drawing.Point(418, 26);
            this.buRR.Name = "buRR";
            this.buRR.Size = new System.Drawing.Size(173, 39);
            this.buRR.TabIndex = 41;
            this.buRR.Text = "Создать ружье";
            this.buRR.UseVisualStyleBackColor = false;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 898);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.buRnd);
            this.Controls.Add(this.buStop);
            this.Controls.Add(this.buPlay);
            this.Controls.Add(this.buReset);
            this.Controls.Add(this.buInfo);
            this.Controls.Add(this.buRR);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button buRnd;
        private System.Windows.Forms.Button buInfo;
        private System.Windows.Forms.Button buRR;
    }
}

