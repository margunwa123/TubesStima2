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
            this.exitHowToButton = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.simulateButton = new System.Windows.Forms.Label();
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
            this.title.Font = new System.Drawing.Font("Gadugi", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(395, 278);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(423, 80);
            this.title.TabIndex = 0;
            this.title.Text = "CoronaVirus";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // howToTitle
            // 
            this.howToTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToTitle.AutoSize = true;
            this.howToTitle.BackColor = System.Drawing.Color.Black;
            this.howToTitle.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToTitle.Location = new System.Drawing.Point(456, 270);
            this.howToTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howToTitle.Name = "howToTitle";
            this.howToTitle.Size = new System.Drawing.Size(301, 41);
            this.howToTitle.TabIndex = 4;
            this.howToTitle.Text = "How To Simulate";
            // 
            // howToStep
            // 
            this.howToStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToStep.AutoSize = true;
            this.howToStep.BackColor = System.Drawing.Color.Black;
            this.howToStep.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToStep.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToStep.Location = new System.Drawing.Point(387, 328);
            this.howToStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howToStep.Name = "howToStep";
            this.howToStep.Size = new System.Drawing.Size(440, 196);
            this.howToStep.TabIndex = 5;
            this.howToStep.Text = "1. Click the Simulation Button\n\n2. Choose your population and graph\n    text file" +
    "s location\n\n3. Select the number of days the\n    spreading occurs";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.exitHowToButton);
            this.groupBox1.Location = new System.Drawing.Point(340, 240);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(533, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // exitHowToButton
            // 
            this.exitHowToButton.AutoSize = true;
            this.exitHowToButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitHowToButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitHowToButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitHowToButton.Location = new System.Drawing.Point(500, 12);
            this.exitHowToButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitHowToButton.Name = "exitHowToButton";
            this.exitHowToButton.Size = new System.Drawing.Size(28, 28);
            this.exitHowToButton.TabIndex = 0;
            this.exitHowToButton.Text = "X";
            this.exitHowToButton.Click += new System.EventHandler(this.exitHowToButton_Click);
            // 
            // subtitle
            // 
            this.subtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.Transparent;
            this.subtitle.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.subtitle.Location = new System.Drawing.Point(446, 346);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(322, 30);
            this.subtitle.TabIndex = 0;
            this.subtitle.Text = "S   I   M   U   L   A   T   O   R";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simulateButton
            // 
            this.simulateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simulateButton.AutoSize = true;
            this.simulateButton.BackColor = System.Drawing.Color.Transparent;
            this.simulateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulateButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.simulateButton.Location = new System.Drawing.Point(554, 405);
            this.simulateButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(106, 21);
            this.simulateButton.TabIndex = 1;
            this.simulateButton.Text = "Simulation";
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // howToButton
            // 
            this.howToButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToButton.AutoSize = true;
            this.howToButton.BackColor = System.Drawing.Color.Transparent;
            this.howToButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.howToButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToButton.Location = new System.Drawing.Point(581, 442);
            this.howToButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howToButton.Name = "howToButton";
            this.howToButton.Size = new System.Drawing.Size(52, 21);
            this.howToButton.TabIndex = 7;
            this.howToButton.Text = "Help";
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
            this.exitButton.Location = new System.Drawing.Point(585, 479);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(43, 21);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1212, 800);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.howToButton);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.howToStep);
            this.Controls.Add(this.howToTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label exitHowToButton;
        private System.Windows.Forms.Label simulateButton;
        private System.Windows.Forms.Label howToButton;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label subtitle;
    }
}

