﻿namespace labRoadEditor
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
            this.Download = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.LaPreview = new System.Windows.Forms.Label();
            this.AllPanel = new System.Windows.Forms.Panel();
            this.PiMap = new System.Windows.Forms.PictureBox();
            this.PiPreview = new System.Windows.Forms.PictureBox();
            this.PiSample = new System.Windows.Forms.PictureBox();
            this.XYPiSample = new System.Windows.Forms.Label();
            this.Cleaning = new System.Windows.Forms.Button();
            this.BaProgress = new MaterialSkin.Controls.MaterialProgressBar();
            this.AllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiSample)).BeginInit();
            this.SuspendLayout();
            // 
            // Download
            // 
            this.Download.AutoSize = true;
            this.Download.BackColor = System.Drawing.Color.Transparent;
            this.Download.FlatAppearance.BorderSize = 0;
            this.Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download.Location = new System.Drawing.Point(261, 24);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(121, 39);
            this.Download.TabIndex = 23;
            this.Download.Text = "Загрузить";
            this.Download.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.Coral;
            this.Save.Location = new System.Drawing.Point(134, 24);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 39);
            this.Save.TabIndex = 22;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // LaPreview
            // 
            this.LaPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LaPreview.AutoSize = true;
            this.LaPreview.BackColor = System.Drawing.Color.Transparent;
            this.LaPreview.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaPreview.Location = new System.Drawing.Point(12, 509);
            this.LaPreview.Name = "LaPreview";
            this.LaPreview.Size = new System.Drawing.Size(116, 25);
            this.LaPreview.TabIndex = 26;
            this.LaPreview.Text = "Preview:";
            // 
            // AllPanel
            // 
            this.AllPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AllPanel.Controls.Add(this.PiMap);
            this.AllPanel.Location = new System.Drawing.Point(438, 156);
            this.AllPanel.Name = "AllPanel";
            this.AllPanel.Size = new System.Drawing.Size(826, 615);
            this.AllPanel.TabIndex = 27;
            // 
            // PiMap
            // 
            this.PiMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(123)))));
            this.PiMap.Location = new System.Drawing.Point(48, 60);
            this.PiMap.Name = "PiMap";
            this.PiMap.Size = new System.Drawing.Size(712, 500);
            this.PiMap.TabIndex = 26;
            this.PiMap.TabStop = false;
            // 
            // PiPreview
            // 
            this.PiPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PiPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(123)))));
            this.PiPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PiPreview.Location = new System.Drawing.Point(12, 537);
            this.PiPreview.Name = "PiPreview";
            this.PiPreview.Size = new System.Drawing.Size(143, 113);
            this.PiPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PiPreview.TabIndex = 25;
            this.PiPreview.TabStop = false;
            // 
            // PiSample
            // 
            this.PiSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PiSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PiSample.Image = global::labRoadEditor.Properties.Resources.road;
            this.PiSample.Location = new System.Drawing.Point(12, 656);
            this.PiSample.MaximumSize = new System.Drawing.Size(800, 600);
            this.PiSample.Name = "PiSample";
            this.PiSample.Size = new System.Drawing.Size(229, 182);
            this.PiSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PiSample.TabIndex = 24;
            this.PiSample.TabStop = false;
            // 
            // XYPiSample
            // 
            this.XYPiSample.AutoSize = true;
            this.XYPiSample.BackColor = System.Drawing.Color.Transparent;
            this.XYPiSample.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.XYPiSample.ForeColor = System.Drawing.Color.Black;
            this.XYPiSample.Location = new System.Drawing.Point(161, 625);
            this.XYPiSample.Name = "XYPiSample";
            this.XYPiSample.Size = new System.Drawing.Size(142, 25);
            this.XYPiSample.TabIndex = 28;
            this.XYPiSample.Text = "{ 1  : 1 }";
            // 
            // Cleaning
            // 
            this.Cleaning.AutoSize = true;
            this.Cleaning.BackColor = System.Drawing.Color.Transparent;
            this.Cleaning.FlatAppearance.BorderSize = 0;
            this.Cleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cleaning.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cleaning.Location = new System.Drawing.Point(388, 24);
            this.Cleaning.Name = "Cleaning";
            this.Cleaning.Size = new System.Drawing.Size(121, 39);
            this.Cleaning.TabIndex = 29;
            this.Cleaning.Text = "Очистить";
            this.Cleaning.UseVisualStyleBackColor = false;
            // 
            // BaProgress
            // 
            this.BaProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaProgress.BackColor = System.Drawing.Color.Aquamarine;
            this.BaProgress.Depth = 0;
            this.BaProgress.Location = new System.Drawing.Point(515, 44);
            this.BaProgress.Maximum = 105;
            this.BaProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.BaProgress.Name = "BaProgress";
            this.BaProgress.Size = new System.Drawing.Size(772, 5);
            this.BaProgress.TabIndex = 31;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1350, 850);
            this.Controls.Add(this.BaProgress);
            this.Controls.Add(this.Cleaning);
            this.Controls.Add(this.XYPiSample);
            this.Controls.Add(this.LaPreview);
            this.Controls.Add(this.PiPreview);
            this.Controls.Add(this.PiSample);
            this.Controls.Add(this.AllPanel);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Save);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "fm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "labRoadEditor";
            this.AllPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PiMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox PiSample;
        private System.Windows.Forms.PictureBox PiPreview;
        private System.Windows.Forms.Label LaPreview;
        private System.Windows.Forms.PictureBox PiMap;
        private System.Windows.Forms.Panel AllPanel;
        private System.Windows.Forms.Label XYPiSample;
        private System.Windows.Forms.Button Cleaning;
        private MaterialSkin.Controls.MaterialProgressBar BaProgress;
    }
}

