namespace Ex
{
    partial class Size_setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buOk = new System.Windows.Forms.Button();
            this.Gridsize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buX = new System.Windows.Forms.Button();
            this.laName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gridsize)).BeginInit();
            this.SuspendLayout();
            // 
            // buOk
            // 
            this.buOk.AutoSize = true;
            this.buOk.BackColor = System.Drawing.Color.Transparent;
            this.buOk.FlatAppearance.BorderSize = 0;
            this.buOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buOk.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buOk.ForeColor = System.Drawing.Color.Coral;
            this.buOk.Location = new System.Drawing.Point(234, 49);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(52, 39);
            this.buOk.TabIndex = 39;
            this.buOk.Text = "✔";
            this.buOk.UseVisualStyleBackColor = false;
            // 
            // Gridsize
            // 
            this.Gridsize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridsize.CausesValidation = false;
            this.Gridsize.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.Gridsize.ForeColor = System.Drawing.Color.Coral;
            this.Gridsize.Location = new System.Drawing.Point(166, 55);
            this.Gridsize.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Gridsize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Gridsize.Name = "Gridsize";
            this.Gridsize.Size = new System.Drawing.Size(62, 33);
            this.Gridsize.TabIndex = 38;
            this.Gridsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gridsize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Размер сетки:";
            // 
            // buX
            // 
            this.buX.BackColor = System.Drawing.Color.Transparent;
            this.buX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buX.FlatAppearance.BorderSize = 0;
            this.buX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buX.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buX.ForeColor = System.Drawing.Color.Crimson;
            this.buX.Location = new System.Drawing.Point(263, -8);
            this.buX.Margin = new System.Windows.Forms.Padding(0);
            this.buX.Name = "buX";
            this.buX.Size = new System.Drawing.Size(39, 46);
            this.buX.TabIndex = 41;
            this.buX.Text = "✖";
            this.buX.UseVisualStyleBackColor = false;
            // 
            // laName
            // 
            this.laName.BackColor = System.Drawing.Color.Transparent;
            this.laName.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.laName.ForeColor = System.Drawing.Color.OrangeRed;
            this.laName.Location = new System.Drawing.Point(1, -8);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(259, 46);
            this.laName.TabIndex = 42;
            this.laName.Text = "Setting Panel";
            this.laName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.laName.UseMnemonic = false;
            // 
            // Size_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(295, 96);
            this.Controls.Add(this.laName);
            this.Controls.Add(this.buX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.Gridsize);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Size_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Size_setting";
            ((System.ComponentModel.ISupportInitialize)(this.Gridsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.NumericUpDown Gridsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buX;
        private System.Windows.Forms.Label laName;
    }
}