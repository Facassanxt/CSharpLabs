﻿namespace Final_project_2020
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
            this.colorSlider1 = new MB.Controls.ColorSlider();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // buReset
            // 
            this.buReset.AutoSize = true;
            this.buReset.BackColor = System.Drawing.Color.Transparent;
            this.buReset.FlatAppearance.BorderSize = 0;
            this.buReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buReset.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buReset.ForeColor = System.Drawing.Color.Coral;
            this.buReset.Location = new System.Drawing.Point(331, 26);
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
            this.buPlay.Location = new System.Drawing.Point(435, 26);
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
            this.buStop.Location = new System.Drawing.Point(519, 26);
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
            // colorSlider1
            // 
            this.colorSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(1, 1);
            this.colorSlider1.LargeChange = ((uint)(5u));
            this.colorSlider1.Location = new System.Drawing.Point(988, 26);
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.Size = new System.Drawing.Size(200, 30);
            this.colorSlider1.SmallChange = ((uint)(1u));
            this.colorSlider1.TabIndex = 0;
            this.colorSlider1.Text = "colorSlider1";
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 898);
            this.Controls.Add(this.colorSlider1);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.buRnd);
            this.Controls.Add(this.buStop);
            this.Controls.Add(this.buPlay);
            this.Controls.Add(this.buReset);
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
        private MB.Controls.ColorSlider colorSlider1;
    }
}

