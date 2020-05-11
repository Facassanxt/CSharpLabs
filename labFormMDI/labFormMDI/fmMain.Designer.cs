namespace labFormMDI
{
    partial class fmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miCreateeNewForm = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowsCTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowsTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowsArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.micloseActiveForm = new System.Windows.Forms.ToolStripMenuItem();
            this.micloseAllForms = new System.Windows.Forms.ToolStripMenuItem();
            this.miabout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateeNewForm,
            this.windowsToolStripMenuItem,
            this.micloseActiveForm,
            this.micloseAllForms,
            this.miabout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miCreateeNewForm
            // 
            this.miCreateeNewForm.Name = "miCreateeNewForm";
            this.miCreateeNewForm.Size = new System.Drawing.Size(105, 20);
            this.miCreateeNewForm.Text = "CreateNewForm";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWindowsCascade,
            this.miWindowsCTileHorizontal,
            this.miWindowsTileVertical,
            this.miWindowsArrangeIcons});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // miWindowsCascade
            // 
            this.miWindowsCascade.Name = "miWindowsCascade";
            this.miWindowsCascade.Size = new System.Drawing.Size(180, 22);
            this.miWindowsCascade.Text = "1";
            // 
            // miWindowsCTileHorizontal
            // 
            this.miWindowsCTileHorizontal.Name = "miWindowsCTileHorizontal";
            this.miWindowsCTileHorizontal.Size = new System.Drawing.Size(180, 22);
            this.miWindowsCTileHorizontal.Text = "2";
            // 
            // miWindowsTileVertical
            // 
            this.miWindowsTileVertical.Name = "miWindowsTileVertical";
            this.miWindowsTileVertical.Size = new System.Drawing.Size(180, 22);
            this.miWindowsTileVertical.Text = "3";
            // 
            // miWindowsArrangeIcons
            // 
            this.miWindowsArrangeIcons.Name = "miWindowsArrangeIcons";
            this.miWindowsArrangeIcons.Size = new System.Drawing.Size(180, 22);
            this.miWindowsArrangeIcons.Text = "4";
            // 
            // closeActiveFormToolStripMenuItem
            // 
            this.micloseActiveForm.Name = "closeActiveFormToolStripMenuItem";
            this.micloseActiveForm.Size = new System.Drawing.Size(109, 20);
            this.micloseActiveForm.Text = "CloseActiveForm";
            // 
            // closeAllFormsToolStripMenuItem
            // 
            this.micloseAllForms.Name = "closeAllFormsToolStripMenuItem";
            this.micloseAllForms.Size = new System.Drawing.Size(95, 20);
            this.micloseAllForms.Text = "CloseAllForms";
            // 
            // aboutToolStripMenuItem
            // 
            this.miabout.Name = "aboutToolStripMenuItem";
            this.miabout.Size = new System.Drawing.Size(52, 20);
            this.miabout.Text = "About";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "labFormMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miCreateeNewForm;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miWindowsCascade;
        private System.Windows.Forms.ToolStripMenuItem miWindowsCTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem miWindowsTileVertical;
        private System.Windows.Forms.ToolStripMenuItem miWindowsArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem micloseActiveForm;
        private System.Windows.Forms.ToolStripMenuItem micloseAllForms;
        private System.Windows.Forms.ToolStripMenuItem miabout;
    }
}

