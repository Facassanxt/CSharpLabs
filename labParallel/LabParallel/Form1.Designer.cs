namespace LabParallel
{
    partial class Form1
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
            this.edDirTemp = new System.Windows.Forms.TextBox();
            this.buCreateFiles = new System.Windows.Forms.Button();
            this.buDeleteFiles = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edDirTemp
            // 
            this.edDirTemp.Location = new System.Drawing.Point(12, 12);
            this.edDirTemp.Name = "edDirTemp";
            this.edDirTemp.Size = new System.Drawing.Size(510, 20);
            this.edDirTemp.TabIndex = 0;
            // 
            // button1
            // 
            this.buCreateFiles.Location = new System.Drawing.Point(12, 38);
            this.buCreateFiles.Name = "button1";
            this.buCreateFiles.Size = new System.Drawing.Size(75, 23);
            this.buCreateFiles.TabIndex = 1;
            this.buCreateFiles.Text = "Создать";
            this.buCreateFiles.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buDeleteFiles.Location = new System.Drawing.Point(93, 38);
            this.buDeleteFiles.Name = "button2";
            this.buDeleteFiles.Size = new System.Drawing.Size(75, 23);
            this.buDeleteFiles.TabIndex = 2;
            this.buDeleteFiles.Text = "Удалить";
            this.buDeleteFiles.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(500, 371);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buDeleteFiles);
            this.Controls.Add(this.buCreateFiles);
            this.Controls.Add(this.edDirTemp);
            this.Name = "Form1";
            this.Text = "LabParallel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edDirTemp;
        private System.Windows.Forms.Button buCreateFiles;
        private System.Windows.Forms.Button buDeleteFiles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

