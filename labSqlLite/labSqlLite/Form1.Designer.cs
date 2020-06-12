namespace labSqlLite
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
            this.label1 = new System.Windows.Forms.Label();
            this.edSQL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buUsersShow = new System.Windows.Forms.Button();
            this.buNotesShow = new System.Windows.Forms.Button();
            this.buRunOne = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edNotesCaption = new System.Windows.Forms.TextBox();
            this.buNotesAdd = new System.Windows.Forms.Button();
            this.edNotesPriority = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.lvLogs = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNotesPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log";
            // 
            // edNgh
            // 
            this.edSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edSQL.Location = new System.Drawing.Point(363, 39);
            this.edSQL.Multiline = true;
            this.edSQL.Name = "edNgh";
            this.edSQL.Size = new System.Drawing.Size(393, 101);
            this.edSQL.TabIndex = 3;
            this.edSQL.Text = "fdgfdgfd";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Query";
            // 
            // buUsersShow
            // 
            this.buUsersShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buUsersShow.Location = new System.Drawing.Point(363, 146);
            this.buUsersShow.Name = "buUsersShow";
            this.buUsersShow.Size = new System.Drawing.Size(102, 33);
            this.buUsersShow.TabIndex = 5;
            this.buUsersShow.Text = "Пользователи";
            this.buUsersShow.UseVisualStyleBackColor = true;
            // 
            // buNotesShow
            // 
            this.buNotesShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buNotesShow.Location = new System.Drawing.Point(471, 146);
            this.buNotesShow.Name = "buNotesShow";
            this.buNotesShow.Size = new System.Drawing.Size(75, 33);
            this.buNotesShow.TabIndex = 6;
            this.buNotesShow.Text = "Заметки";
            this.buNotesShow.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.buRunOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buRunOne.Location = new System.Drawing.Point(550, 146);
            this.buRunOne.Name = "button3";
            this.buRunOne.Size = new System.Drawing.Size(81, 33);
            this.buRunOne.TabIndex = 7;
            this.buRunOne.Text = "Выполнить";
            this.buRunOne.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 252);
            this.dataGridView1.TabIndex = 8;
            // 
            // edNotes
            // 
            this.edNotesCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edNotesCaption.Location = new System.Drawing.Point(363, 443);
            this.edNotesCaption.Name = "edNotes";
            this.edNotesCaption.Size = new System.Drawing.Size(183, 20);
            this.edNotesCaption.TabIndex = 9;
            // 
            // buNotesAdd
            // 
            this.buNotesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buNotesAdd.Location = new System.Drawing.Point(637, 442);
            this.buNotesAdd.Name = "buNotesAdd";
            this.buNotesAdd.Size = new System.Drawing.Size(119, 21);
            this.buNotesAdd.TabIndex = 10;
            this.buNotesAdd.Text = "+ Заметка";
            this.buNotesAdd.UseVisualStyleBackColor = true;
            // 
            // ediuo
            // 
            this.edNotesPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edNotesPriority.Location = new System.Drawing.Point(550, 444);
            this.edNotesPriority.Name = "ediuo";
            this.edNotesPriority.Size = new System.Drawing.Size(81, 20);
            this.edNotesPriority.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(637, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 33);
            this.button5.TabIndex = 12;
            this.button5.Text = "Выполнить SQL";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lvLogs
            // 
            this.lvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(12, 39);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(346, 425);
            this.lvLogs.TabIndex = 13;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 471);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.edNotesPriority);
            this.Controls.Add(this.buNotesAdd);
            this.Controls.Add(this.edNotesCaption);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buRunOne);
            this.Controls.Add(this.buNotesShow);
            this.Controls.Add(this.buUsersShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edSQL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "labSqlLite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNotesPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buUsersShow;
        private System.Windows.Forms.Button buNotesShow;
        private System.Windows.Forms.Button buRunOne;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox edNotesCaption;
        private System.Windows.Forms.Button buNotesAdd;
        private System.Windows.Forms.NumericUpDown edNotesPriority;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView lvLogs;
    }
}

