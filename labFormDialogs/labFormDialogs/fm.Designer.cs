namespace labFormDialogs
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenDialog = new System.Windows.Forms.TextBox();
            this.buDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenDialog
            // 
            this.OpenDialog.Location = new System.Drawing.Point(12, 33);
            this.OpenDialog.Name = "OpenDialog";
            this.OpenDialog.Size = new System.Drawing.Size(633, 20);
            this.OpenDialog.TabIndex = 0;
            // 
            // buDialog
            // 
            this.buDialog.Location = new System.Drawing.Point(651, 30);
            this.buDialog.Name = "buDialog";
            this.buDialog.Size = new System.Drawing.Size(137, 23);
            this.buDialog.TabIndex = 1;
            this.buDialog.Text = "OpenDialog";
            this.buDialog.UseVisualStyleBackColor = true;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buDialog);
            this.Controls.Add(this.OpenDialog);
            this.Name = "fm";
            this.Text = "labFormDialogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox OpenDialog;
        private System.Windows.Forms.Button buDialog;
    }
}

