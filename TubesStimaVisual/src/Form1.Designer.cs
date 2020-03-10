namespace TubesStimaVisual
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.howToTitle = new System.Windows.Forms.Label();
            this.howToStep = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Label();
            this.howToButton = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(94, 95);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(412, 34);
            this.title.TabIndex = 0;
            this.title.Text = "CoronaVirus Spread Simulator";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // howToTitle
            // 
            this.howToTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToTitle.AutoSize = true;
            this.howToTitle.BackColor = System.Drawing.Color.Black;
            this.howToTitle.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToTitle.Location = new System.Drawing.Point(210, 75);
            this.howToTitle.Name = "howToTitle";
            this.howToTitle.Size = new System.Drawing.Size(179, 34);
            this.howToTitle.TabIndex = 4;
            this.howToTitle.Text = "How To Play";
            // 
            // howToStep
            // 
            this.howToStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToStep.AutoSize = true;
            this.howToStep.BackColor = System.Drawing.Color.Black;
            this.howToStep.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToStep.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToStep.Location = new System.Drawing.Point(275, 144);
            this.howToStep.Name = "howToStep";
            this.howToStep.Size = new System.Drawing.Size(51, 50);
            this.howToStep.TabIndex = 5;
            this.howToStep.Text = "1. A\n2. B";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(100, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 250);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(372, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.AutoSize = true;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.playButton.Location = new System.Drawing.Point(279, 170);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(43, 19);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play!";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // howToButton
            // 
            this.howToButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToButton.AutoSize = true;
            this.howToButton.BackColor = System.Drawing.Color.Transparent;
            this.howToButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.howToButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToButton.Location = new System.Drawing.Point(252, 200);
            this.howToButton.Name = "howToButton";
            this.howToButton.Size = new System.Drawing.Size(96, 19);
            this.howToButton.TabIndex = 7;
            this.howToButton.Text = "How To Play";
            this.howToButton.Click += new System.EventHandler(this.howToButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(283, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 19);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.howToButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.howToStep);
            this.Controls.Add(this.howToTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label howToTitle;
        private System.Windows.Forms.Label howToStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playButton;
        private System.Windows.Forms.Label howToButton;
        private System.Windows.Forms.Label exitButton;
    }
}

