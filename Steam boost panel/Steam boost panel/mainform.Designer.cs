namespace Steam_boost_panel
{
    partial class mainform
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Panel_header = new System.Windows.Forms.Panel();
            this.buClose = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buСollapse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.Panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(271, 169);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(296, 133);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "MOUSE MOVE";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_header
            // 
            this.Panel_header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_header.Controls.Add(this.buСollapse);
            this.Panel_header.Controls.Add(this.buClose);
            this.Panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_header.Location = new System.Drawing.Point(0, 0);
            this.Panel_header.Name = "Panel_header";
            this.Panel_header.Size = new System.Drawing.Size(800, 49);
            this.Panel_header.TabIndex = 1;
            // 
            // buClose
            // 
            this.buClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buClose.BackColor = System.Drawing.Color.Transparent;
            this.buClose.FlatAppearance.BorderSize = 0;
            this.buClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buClose.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.buClose.ForeColor = System.Drawing.Color.DarkRed;
            this.buClose.Location = new System.Drawing.Point(772, 0);
            this.buClose.Margin = new System.Windows.Forms.Padding(0);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(30, 49);
            this.buClose.TabIndex = 0;
            this.buClose.Text = "X";
            this.buClose.UseVisualStyleBackColor = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(141, 329);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 100);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // buСollapse
            // 
            this.buСollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buСollapse.BackColor = System.Drawing.Color.Transparent;
            this.buСollapse.FlatAppearance.BorderSize = 0;
            this.buСollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buСollapse.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.buСollapse.ForeColor = System.Drawing.Color.DarkRed;
            this.buСollapse.Location = new System.Drawing.Point(742, 0);
            this.buСollapse.Margin = new System.Windows.Forms.Padding(0);
            this.buСollapse.Name = "buСollapse";
            this.buСollapse.Size = new System.Drawing.Size(30, 49);
            this.buСollapse.TabIndex = 1;
            this.buСollapse.Text = "-";
            this.buСollapse.UseVisualStyleBackColor = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Panel_header);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.Panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel Panel_header;
        private System.Windows.Forms.Button buClose;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button buСollapse;
    }
}

