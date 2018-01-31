namespace Xadrez
{
    partial class Tabuleiro
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
            this.components = new System.ComponentModel.Container();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBoxTitlePiece2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitlePiece1 = new System.Windows.Forms.PictureBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerWhitePieces = new System.Windows.Forms.Timer(this.components);
            this.timerBlackPieces = new System.Windows.Forms.Timer(this.components);
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitlePiece2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitlePiece1)).BeginInit();
            this.panelPlayer1.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.panelPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.Controls.Add(this.pictureBoxTitlePiece2);
            this.panelTitle.Controls.Add(this.pictureBoxTitlePiece1);
            this.panelTitle.Controls.Add(this.labelExit);
            this.panelTitle.Controls.Add(this.labelMinimize);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(974, 76);
            this.panelTitle.TabIndex = 6;
            // 
            // pictureBoxTitlePiece2
            // 
            this.pictureBoxTitlePiece2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTitlePiece2.BackgroundImage = global::Xadrez.Properties.Resources.Tittle_Image;
            this.pictureBoxTitlePiece2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTitlePiece2.Location = new System.Drawing.Point(557, -2);
            this.pictureBoxTitlePiece2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTitlePiece2.Name = "pictureBoxTitlePiece2";
            this.pictureBoxTitlePiece2.Size = new System.Drawing.Size(88, 76);
            this.pictureBoxTitlePiece2.TabIndex = 6;
            this.pictureBoxTitlePiece2.TabStop = false;
            // 
            // pictureBoxTitlePiece1
            // 
            this.pictureBoxTitlePiece1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTitlePiece1.BackgroundImage = global::Xadrez.Properties.Resources.Tittle_Image;
            this.pictureBoxTitlePiece1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTitlePiece1.Location = new System.Drawing.Point(358, -2);
            this.pictureBoxTitlePiece1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTitlePiece1.Name = "pictureBoxTitlePiece1";
            this.pictureBoxTitlePiece1.Size = new System.Drawing.Size(89, 76);
            this.pictureBoxTitlePiece1.TabIndex = 5;
            this.pictureBoxTitlePiece1.TabStop = false;
            // 
            // labelExit
            // 
            this.labelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(958, 1);
            this.labelExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(17, 20);
            this.labelExit.TabIndex = 4;
            this.labelExit.Text = "x";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelMinimize
            // 
            this.labelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.Color.White;
            this.labelMinimize.Location = new System.Drawing.Point(937, 0);
            this.labelMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(17, 22);
            this.labelMinimize.TabIndex = 3;
            this.labelMinimize.Text = "-";
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(437, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(128, 53);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Chess";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.BackColor = System.Drawing.Color.White;
            this.panelPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPlayer1.CausesValidation = false;
            this.panelPlayer1.Controls.Add(this.labelPlayer1);
            this.panelPlayer1.Location = new System.Drawing.Point(589, 0);
            this.panelPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(369, 282);
            this.panelPlayer1.TabIndex = 161;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.Black;
            this.labelPlayer1.Location = new System.Drawing.Point(254, 0);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(111, 35);
            this.labelPlayer1.TabIndex = 2;
            this.labelPlayer1.Text = "Player 1";
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.Transparent;
            this.panelFill.Controls.Add(this.panelPlayer2);
            this.panelFill.Controls.Add(this.panelPlayer1);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Enabled = false;
            this.panelFill.Location = new System.Drawing.Point(0, 76);
            this.panelFill.Margin = new System.Windows.Forms.Padding(2);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(974, 571);
            this.panelFill.TabIndex = 162;
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.BackColor = System.Drawing.Color.White;
            this.panelPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPlayer2.Controls.Add(this.label1);
            this.panelPlayer2.Location = new System.Drawing.Point(589, 286);
            this.panelPlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(369, 274);
            this.panelPlayer2.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 2";
            // 
            // timerWhitePieces
            // 
            this.timerWhitePieces.Interval = 125;
            this.timerWhitePieces.Tick += new System.EventHandler(this.timerWhitePieces_Tick);
            // 
            // timerBlackPieces
            // 
            this.timerBlackPieces.Interval = 125;
            this.timerBlackPieces.Tick += new System.EventHandler(this.timerBlackPieces_Tick);
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Xadrez.Properties.Resources.Chess_Wallpapper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 647);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitlePiece2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitlePiece1)).EndInit();
            this.panelPlayer1.ResumeLayout(false);
            this.panelPlayer1.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.panelPlayer2.ResumeLayout(false);
            this.panelPlayer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTitlePiece2;
        private System.Windows.Forms.PictureBox pictureBoxTitlePiece1;
        private System.Windows.Forms.Timer timerWhitePieces;
        private System.Windows.Forms.Timer timerBlackPieces;
    }
}