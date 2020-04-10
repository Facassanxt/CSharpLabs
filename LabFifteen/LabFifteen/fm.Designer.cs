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
            this.laTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.laSteps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.won = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.OkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Shift = new MaterialSkin.Controls.MaterialCheckBox();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Pa = new System.Windows.Forms.Panel();
            this.PA2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.Pa.SuspendLayout();
            this.PA2.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTime
            // 
            this.laTime.BackColor = System.Drawing.Color.Transparent;
            this.laTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.laTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laTime.Location = new System.Drawing.Point(11, 1);
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
            this.laSteps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laSteps.Location = new System.Drawing.Point(125, 4);
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
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Шаги:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // won
            // 
            this.won.BackColor = System.Drawing.Color.AntiqueWhite;
            this.won.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.won.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.won.Location = new System.Drawing.Point(11, 74);
            this.won.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(216, 185);
            this.won.TabIndex = 40;
            this.won.Text = " You won!";
            this.won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.won.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.ModesToolStripMenuItem,
            this.StartToolStripMenuItem,
            this.RestartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(62, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 35);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.PToolStripMenuItem});
            this.GameToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(68, 31);
            this.GameToolStripMenuItem.Text = "Игра";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtomToolStripMenuItem,
            this.TextToolStripMenuItem,
            this.LightToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.sToolStripMenuItem.Text = "Изменения стиля";
            // 
            // ButtomToolStripMenuItem
            // 
            this.ButtomToolStripMenuItem.Name = "ButtomToolStripMenuItem";
            this.ButtomToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.ButtomToolStripMenuItem.Text = "Цвет Кнопки";
            // 
            // TextToolStripMenuItem
            // 
            this.TextToolStripMenuItem.Name = "TextToolStripMenuItem";
            this.TextToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.TextToolStripMenuItem.Text = "Текст Кнопки";
            // 
            // LightToolStripMenuItem
            // 
            this.LightToolStripMenuItem.Name = "LightToolStripMenuItem";
            this.LightToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.LightToolStripMenuItem.Text = "Светлая тема";
            // 
            // PToolStripMenuItem
            // 
            this.PToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PToolStripMenuItem.Name = "PToolStripMenuItem";
            this.PToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.PToolStripMenuItem.Text = "Открыть навигацию";
            // 
            // ModesToolStripMenuItem
            // 
            this.ModesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ModesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.OkToolStripMenuItem});
            this.ModesToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.ModesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModesToolStripMenuItem.Name = "ModesToolStripMenuItem";
            this.ModesToolStripMenuItem.Size = new System.Drawing.Size(102, 31);
            this.ModesToolStripMenuItem.Text = "Режимы";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.x3ToolStripMenuItem.Text = "3 x 3";
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.x4ToolStripMenuItem.Text = "4 x 4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1.MaxLength = 2;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 33);
            // 
            // OkToolStripMenuItem
            // 
            this.OkToolStripMenuItem.Name = "OkToolStripMenuItem";
            this.OkToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.OkToolStripMenuItem.Text = "Подтвердить";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.StartToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(93, 31);
            this.StartToolStripMenuItem.Text = "Старт";
            // 
            // RestartToolStripMenuItem
            // 
            this.RestartToolStripMenuItem.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.RestartToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
            this.RestartToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.RestartToolStripMenuItem.Text = "Рестарт";
            // 
            // Shift
            // 
            this.Shift.BackColor = System.Drawing.Color.Transparent;
            this.Shift.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shift.Depth = 0;
            this.Shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Shift.Location = new System.Drawing.Point(3, 79);
            this.Shift.Margin = new System.Windows.Forms.Padding(0);
            this.Shift.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Shift.MouseState = MaterialSkin.MouseState.HOVER;
            this.Shift.Name = "Shift";
            this.Shift.Ripple = true;
            this.Shift.Size = new System.Drawing.Size(69, 30);
            this.Shift.TabIndex = 51;
            this.Shift.Text = "Shift";
            this.Shift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shift.UseVisualStyleBackColor = false;
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.Color.White;
            this.Up.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.Up.Location = new System.Drawing.Point(141, 3);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(50, 50);
            this.Up.TabIndex = 45;
            this.Up.Text = "↑";
            this.Up.UseVisualStyleBackColor = false;
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.Color.White;
            this.Down.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.Down.Location = new System.Drawing.Point(141, 59);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(50, 50);
            this.Down.TabIndex = 47;
            this.Down.Text = "↓";
            this.Down.UseVisualStyleBackColor = false;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.White;
            this.Right.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.Right.Location = new System.Drawing.Point(197, 59);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(50, 50);
            this.Right.TabIndex = 48;
            this.Right.Text = "→";
            this.Right.UseVisualStyleBackColor = false;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.White;
            this.Left.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold);
            this.Left.Location = new System.Drawing.Point(85, 59);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(50, 50);
            this.Left.TabIndex = 46;
            this.Left.Text = "←";
            this.Left.UseVisualStyleBackColor = false;
            // 
            // Pa
            // 
            this.Pa.Controls.Add(this.Left);
            this.Pa.Controls.Add(this.Right);
            this.Pa.Controls.Add(this.Down);
            this.Pa.Controls.Add(this.Up);
            this.Pa.Controls.Add(this.Shift);
            this.Pa.Location = new System.Drawing.Point(292, 3);
            this.Pa.Name = "Pa";
            this.Pa.Size = new System.Drawing.Size(248, 108);
            this.Pa.TabIndex = 52;
            // 
            // PA2
            // 
            this.PA2.ColumnCount = 2;
            this.PA2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.PA2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.PA2.Controls.Add(this.Pa, 1, 0);
            this.PA2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PA2.Location = new System.Drawing.Point(0, 645);
            this.PA2.Name = "PA2";
            this.PA2.RowCount = 1;
            this.PA2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PA2.Size = new System.Drawing.Size(828, 114);
            this.PA2.TabIndex = 54;
            this.PA2.Visible = false;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(828, 759);
            this.Controls.Add(this.PA2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.laSteps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laTime);
            this.Controls.Add(this.won);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 120);
            this.Name = "fm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fifteen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pa.ResumeLayout(false);
            this.PA2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label laSteps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label won;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ButtomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem OkToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckBox Shift;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Panel Pa;
        private System.Windows.Forms.TableLayoutPanel PA2;
    }
}

