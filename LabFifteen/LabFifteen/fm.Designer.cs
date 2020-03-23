namespace LabFifteen
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
            this.components = new System.ComponentModel.Container();
            this.block0 = new System.Windows.Forms.Button();
            this.laTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.laSteps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.won = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // block0
            // 
            this.block0.BackColor = System.Drawing.Color.PeachPuff;
            this.block0.FlatAppearance.BorderSize = 0;
            this.block0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.block0.ForeColor = System.Drawing.Color.White;
            this.block0.Location = new System.Drawing.Point(294, 348);
            this.block0.Margin = new System.Windows.Forms.Padding(2);
            this.block0.Name = "block0";
            this.block0.Size = new System.Drawing.Size(135, 146);
            this.block0.TabIndex = 17;
            this.block0.Tag = "15";
            this.block0.UseVisualStyleBackColor = false;
            this.block0.Visible = false;
            // 
            // laTime
            // 
            this.laTime.BackColor = System.Drawing.Color.Transparent;
            this.laTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.laTime.Location = new System.Drawing.Point(-4, 0);
            this.laTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(57, 23);
            this.laTime.TabIndex = 18;
            this.laTime.Text = "0:00";
            this.laTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laSteps
            // 
            this.laSteps.BackColor = System.Drawing.Color.Transparent;
            this.laSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laSteps.Location = new System.Drawing.Point(378, 35);
            this.laSteps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laSteps.Name = "laSteps";
            this.laSteps.Size = new System.Drawing.Size(51, 19);
            this.laSteps.TabIndex = 19;
            this.laSteps.Text = "0";
            this.laSteps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(319, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Шаги:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // won
            // 
            this.won.BackColor = System.Drawing.Color.AntiqueWhite;
            this.won.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.won.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.won.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.won.ForeColor = System.Drawing.Color.Red;
            this.won.Location = new System.Drawing.Point(0, 63);
            this.won.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(429, 431);
            this.won.TabIndex = 40;
            this.won.Text = " You won!";
            this.won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.won.Visible = false;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.FlatAppearance.BorderSize = 0;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Black;
            this.Restart.Location = new System.Drawing.Point(210, 25);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(118, 35);
            this.Restart.TabIndex = 42;
            this.Restart.Text = "Собрать";
            this.Restart.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(86, 25);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(118, 35);
            this.Start.TabIndex = 43;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = false;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(429, 494);
            this.Controls.Add(this.laSteps);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laTime);
            this.Controls.Add(this.block0);
            this.Controls.Add(this.won);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(429, 494);
            this.MinimumSize = new System.Drawing.Size(429, 494);
            this.Name = "fm";
            this.Text = "Fifteen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button block0;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label laSteps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label won;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Start;
    }
}

