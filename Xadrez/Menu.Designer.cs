namespace Xadrez
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelMaximize = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelWork = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitleBar.BackgroundImage")));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.labelMinimize);
            this.panelTitleBar.Controls.Add(this.labelMaximize);
            this.panelTitleBar.Controls.Add(this.labelExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(923, 90);
            this.panelTitleBar.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(361, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 70);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Xadrez";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinimize
            // 
            this.labelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.Color.White;
            this.labelMinimize.Location = new System.Drawing.Point(855, 0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(20, 26);
            this.labelMinimize.TabIndex = 2;
            this.labelMinimize.Text = "-";
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            // 
            // labelMaximize
            // 
            this.labelMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaximize.AutoSize = true;
            this.labelMaximize.BackColor = System.Drawing.Color.Transparent;
            this.labelMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaximize.ForeColor = System.Drawing.Color.White;
            this.labelMaximize.Location = new System.Drawing.Point(875, 0);
            this.labelMaximize.Name = "labelMaximize";
            this.labelMaximize.Size = new System.Drawing.Size(25, 24);
            this.labelMaximize.TabIndex = 1;
            this.labelMaximize.Text = "█";
            this.labelMaximize.Click += new System.EventHandler(this.labelMaximize_Click);
            // 
            // labelExit
            // 
            this.labelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(900, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(23, 25);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "x";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // panelWork
            // 
            this.panelWork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelWork.BackgroundImage")));
            this.panelWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWork.Controls.Add(this.buttonAbout);
            this.panelWork.Controls.Add(this.buttonRules);
            this.panelWork.Controls.Add(this.buttonStart);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(0, 90);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(923, 576);
            this.panelWork.TabIndex = 1;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAbout.BackgroundImage")));
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Location = new System.Drawing.Point(339, 431);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(238, 85);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "About Me";
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // buttonRules
            // 
            this.buttonRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRules.BackColor = System.Drawing.Color.Transparent;
            this.buttonRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRules.BackgroundImage")));
            this.buttonRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRules.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRules.ForeColor = System.Drawing.Color.White;
            this.buttonRules.Location = new System.Drawing.Point(339, 237);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(238, 85);
            this.buttonRules.TabIndex = 1;
            this.buttonRules.Text = "Rules";
            this.buttonRules.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStart.BackgroundImage")));
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(339, 129);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(238, 85);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 666);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.panelTitleBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelWork.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelMaximize;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonStart;
    }
}

