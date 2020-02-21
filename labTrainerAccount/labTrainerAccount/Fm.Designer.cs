namespace labTrainerAccount
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
            this.buYes = new System.Windows.Forms.Button();
            this.buNo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.laNo = new System.Windows.Forms.Label();
            this.laYes = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.laCode = new System.Windows.Forms.Label();
            this.buReset = new System.Windows.Forms.Button();
            this.buTest = new System.Windows.Forms.Button();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblRAM = new MaterialSkin.Controls.MaterialLabel();
            this.lblCPU = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // buYes
            // 
            this.buYes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buYes.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buYes.ForeColor = System.Drawing.Color.Green;
            this.buYes.Location = new System.Drawing.Point(3, 3);
            this.buYes.Name = "buYes";
            this.buYes.Size = new System.Drawing.Size(206, 85);
            this.buYes.TabIndex = 0;
            this.buYes.Text = "Да";
            this.buYes.UseVisualStyleBackColor = false;
            // 
            // buNo
            // 
            this.buNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buNo.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buNo.ForeColor = System.Drawing.Color.Maroon;
            this.buNo.Location = new System.Drawing.Point(215, 3);
            this.buNo.Name = "buNo";
            this.buNo.Size = new System.Drawing.Size(207, 85);
            this.buNo.TabIndex = 1;
            this.buNo.Text = "Нет";
            this.buNo.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.laNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.laYes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-6, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 59);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // laNo
            // 
            this.laNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.laNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laNo.Location = new System.Drawing.Point(220, 0);
            this.laNo.Name = "laNo";
            this.laNo.Size = new System.Drawing.Size(212, 59);
            this.laNo.TabIndex = 1;
            this.laNo.Text = "Неверно = 0";
            this.laNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laYes
            // 
            this.laYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.laYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laYes.Location = new System.Drawing.Point(3, 0);
            this.laYes.Name = "laYes";
            this.laYes.Size = new System.Drawing.Size(211, 59);
            this.laYes.TabIndex = 0;
            this.laYes.Text = "Верно = 0";
            this.laYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buYes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buNo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 346);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 91);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Верно?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCode
            // 
            this.laCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.laCode.Font = new System.Drawing.Font("Arial Black", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCode.ForeColor = System.Drawing.Color.White;
            this.laCode.Location = new System.Drawing.Point(0, 116);
            this.laCode.Name = "laCode";
            this.laCode.Size = new System.Drawing.Size(425, 180);
            this.laCode.TabIndex = 5;
            this.laCode.Text = "10 + 11 = 21";
            this.laCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buReset
            // 
            this.buReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buReset.Location = new System.Drawing.Point(52, 31);
            this.buReset.Name = "buReset";
            this.buReset.Size = new System.Drawing.Size(50, 20);
            this.buReset.TabIndex = 6;
            this.buReset.Text = "Reset";
            this.buReset.UseVisualStyleBackColor = true;
            // 
            // buTest
            // 
            this.buTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buTest.Location = new System.Drawing.Point(3, 31);
            this.buTest.Name = "buTest";
            this.buTest.Size = new System.Drawing.Size(43, 20);
            this.buTest.TabIndex = 7;
            this.buTest.Text = "Test";
            this.buTest.UseVisualStyleBackColor = true;
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Process";
            this.pRAM.CounterName = "Private Bytes";
            this.pRAM.InstanceName = "labTrainerAccount";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% User Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // lblRAM
            // 
            this.lblRAM.BackColor = System.Drawing.Color.Transparent;
            this.lblRAM.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRAM.Depth = 0;
            this.lblRAM.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRAM.Location = new System.Drawing.Point(262, 32);
            this.lblRAM.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(151, 20);
            this.lblRAM.TabIndex = 14;
            this.lblRAM.Text = "0 %";
            this.lblRAM.UseMnemonic = false;
            // 
            // lblCPU
            // 
            this.lblCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCPU.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCPU.Depth = 0;
            this.lblCPU.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCPU.Location = new System.Drawing.Point(155, 32);
            this.lblCPU.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(50, 20);
            this.lblCPU.TabIndex = 13;
            this.lblCPU.Text = "0 %";
            this.lblCPU.UseMnemonic = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(211, 32);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(45, 20);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "RAM:";
            this.materialLabel4.UseMnemonic = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(108, 32);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(45, 20);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "CPU:";
            this.materialLabel5.UseMnemonic = false;
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(425, 437);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.buTest);
            this.Controls.Add(this.buReset);
            this.Controls.Add(this.laCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(425, 437);
            this.MinimumSize = new System.Drawing.Size(425, 437);
            this.Name = "Fm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Fm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buYes;
        private System.Windows.Forms.Button buNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label laNo;
        private System.Windows.Forms.Label laYes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laCode;
        private System.Windows.Forms.Button buReset;
        private System.Windows.Forms.Button buTest;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MaterialSkin.Controls.MaterialLabel lblRAM;
        private MaterialSkin.Controls.MaterialLabel lblCPU;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Diagnostics.PerformanceCounter pRAM;
    }
}

