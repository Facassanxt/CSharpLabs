namespace Ex
{
    partial class Game
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
            this.piPlayer = new System.Windows.Forms.PictureBox();
            this.piGame = new System.Windows.Forms.PictureBox();
            this.PiPreviewMAP = new System.Windows.Forms.PictureBox();
            this.piMapPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiPreviewMAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piMapPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // piPlayer
            // 
            this.piPlayer.BackColor = System.Drawing.Color.Transparent;
            this.piPlayer.Image = global::Ex.Properties.Resources._Up;
            this.piPlayer.Location = new System.Drawing.Point(389, 284);
            this.piPlayer.Name = "piPlayer";
            this.piPlayer.Size = new System.Drawing.Size(50, 50);
            this.piPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piPlayer.TabIndex = 1;
            this.piPlayer.TabStop = false;
            // 
            // piGame
            // 
            this.piGame.Location = new System.Drawing.Point(42, 91);
            this.piGame.Name = "piGame";
            this.piGame.Size = new System.Drawing.Size(784, 451);
            this.piGame.TabIndex = 0;
            this.piGame.TabStop = false;
            // 
            // PiPreviewMAP
            // 
            this.PiPreviewMAP.BackColor = System.Drawing.Color.Transparent;
            this.PiPreviewMAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PiPreviewMAP.Enabled = false;
            this.PiPreviewMAP.Location = new System.Drawing.Point(-1, 64);
            this.PiPreviewMAP.Name = "PiPreviewMAP";
            this.PiPreviewMAP.Size = new System.Drawing.Size(320, 320);
            this.PiPreviewMAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PiPreviewMAP.TabIndex = 54;
            this.PiPreviewMAP.TabStop = false;
            // 
            // piMapPlayer
            // 
            this.piMapPlayer.BackColor = System.Drawing.Color.Transparent;
            this.piMapPlayer.Image = global::Ex.Properties.Resources.you_are_here;
            this.piMapPlayer.Location = new System.Drawing.Point(248, 315);
            this.piMapPlayer.Name = "piMapPlayer";
            this.piMapPlayer.Size = new System.Drawing.Size(50, 50);
            this.piMapPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piMapPlayer.TabIndex = 55;
            this.piMapPlayer.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(142)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.piMapPlayer);
            this.Controls.Add(this.PiPreviewMAP);
            this.Controls.Add(this.piPlayer);
            this.Controls.Add(this.piGame);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.piPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiPreviewMAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piMapPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox piGame;
        private System.Windows.Forms.PictureBox piPlayer;
        private System.Windows.Forms.PictureBox PiPreviewMAP;
        private System.Windows.Forms.PictureBox piMapPlayer;
    }
}