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
            this.buRnd = new System.Windows.Forms.Button();
            this.buInfo = new System.Windows.Forms.Button();
            this.buRR = new System.Windows.Forms.Button();
            this.piGame = new System.Windows.Forms.PictureBox();
            this.buTEST = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piGame)).BeginInit();
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
            this.buReset.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
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
            this.buPlay.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
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
            this.buStop.Enabled = false;
            this.buStop.FlatAppearance.BorderSize = 0;
            this.buStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buStop.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buStop.ForeColor = System.Drawing.Color.Coral;
            this.buStop.Location = new System.Drawing.Point(237, 26);
            this.buStop.Name = "buStop";
            this.buStop.Size = new System.Drawing.Size(72, 39);
            this.buStop.TabIndex = 38;
            this.buStop.Text = "Стоп";
            this.buStop.UseVisualStyleBackColor = false;
            // 
            // buRnd
            // 
            this.buRnd.AutoSize = true;
            this.buRnd.BackColor = System.Drawing.Color.Transparent;
            this.buRnd.FlatAppearance.BorderSize = 0;
            this.buRnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buRnd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
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
            this.buInfo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
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
            this.buRR.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buRR.ForeColor = System.Drawing.Color.Coral;
            this.buRR.Location = new System.Drawing.Point(418, 26);
            this.buRR.Name = "buRR";
            this.buRR.Size = new System.Drawing.Size(173, 39);
            this.buRR.TabIndex = 41;
            this.buRR.Text = "Создать ружье";
            this.buRR.UseVisualStyleBackColor = false;
            // 
            // piGame
            // 
            this.piGame.Location = new System.Drawing.Point(34, 91);
            this.piGame.Name = "piGame";
            this.piGame.Size = new System.Drawing.Size(303, 253);
            this.piGame.TabIndex = 42;
            this.piGame.TabStop = false;
            // 
            // buTEST
            // 
            this.buTEST.AutoSize = true;
            this.buTEST.BackColor = System.Drawing.Color.Transparent;
            this.buTEST.FlatAppearance.BorderSize = 0;
            this.buTEST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buTEST.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buTEST.ForeColor = System.Drawing.Color.Coral;
            this.buTEST.Location = new System.Drawing.Point(744, 26);
            this.buTEST.Name = "buTEST";
            this.buTEST.Size = new System.Drawing.Size(96, 39);
            this.buTEST.TabIndex = 43;
            this.buTEST.Text = "TEST";
            this.buTEST.UseVisualStyleBackColor = false;
            this.buTEST.Click += new System.EventHandler(this.buTEST_Click);
            // 
            // Fm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1200, 898);
            this.Controls.Add(this.buTEST);
            this.Controls.Add(this.piGame);
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
            ((System.ComponentModel.ISupportInitialize)(this.piGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buReset;
        private System.Windows.Forms.Button buPlay;
        private System.Windows.Forms.Button buStop;
        private System.Windows.Forms.Button buRnd;
        private System.Windows.Forms.Button buInfo;
        private System.Windows.Forms.Button buRR;
        private System.Windows.Forms.PictureBox piGame;
        private System.Windows.Forms.Button buTEST;
    }
}

