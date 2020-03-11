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
            this.subtitle = new System.Windows.Forms.Label();
            this.simulateButton = new System.Windows.Forms.Label();
            this.howToButton = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.graphOpen = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.graphLabel = new System.Windows.Forms.Label();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.graphTextBox = new System.Windows.Forms.TextBox();
            this.populationOpen = new System.Windows.Forms.Label();
            this.simulate = new System.Windows.Forms.Label();
            this.selectGraph = new System.Windows.Forms.Label();
            this.selectPopulation = new System.Windows.Forms.Label();
            this.backToMenuButton = new System.Windows.Forms.Label();
            this.tempBackground = new System.Windows.Forms.Label();
            this.tempBackgroundGlow1 = new System.Windows.Forms.Label();
            this.tempBackgroundGlow2 = new System.Windows.Forms.Label();
            this.daysSelect = new System.Windows.Forms.Label();
            this.daysSpread = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Gadugi", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(296, 226);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(340, 65);
            this.title.TabIndex = 0;
            this.title.Text = "CoronaVirus";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // howToTitle
            // 
            this.howToTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToTitle.AutoSize = true;
            this.howToTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.howToTitle.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToTitle.Location = new System.Drawing.Point(304, 210);
            this.howToTitle.Name = "howToTitle";
            this.howToTitle.Size = new System.Drawing.Size(301, 41);
            this.howToTitle.TabIndex = 4;
            this.howToTitle.Text = "How To Simulate";
            // 
            // howToStep
            // 
            this.howToStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToStep.AutoSize = true;
            this.howToStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.howToStep.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToStep.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.howToStep.Location = new System.Drawing.Point(229, 290);
            this.howToStep.Name = "howToStep";
            this.howToStep.Size = new System.Drawing.Size(452, 140);
            this.howToStep.TabIndex = 5;
            this.howToStep.Text = "1. Click the Simulation Button\n\n2. Choose your population and graph text files lo" +
    "cation\n\n3. Select the number of days the spreading occurs\n\n4. Click Simulate!";
            // 
            // subtitle
            // 
            this.subtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.Transparent;
            this.subtitle.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.subtitle.Location = new System.Drawing.Point(334, 281);
            this.subtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(267, 24);
            this.subtitle.TabIndex = 0;
            this.subtitle.Text = "S   I   M   U   L   A   T   O   R";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simulateButton
            // 
            this.simulateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simulateButton.AutoSize = true;
            this.simulateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.simulateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulateButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.simulateButton.Location = new System.Drawing.Point(416, 329);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(84, 19);
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
            this.howToButton.Location = new System.Drawing.Point(436, 359);
            this.howToButton.Name = "howToButton";
            this.howToButton.Size = new System.Drawing.Size(41, 19);
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
            this.exitButton.Location = new System.Drawing.Point(439, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 19);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // graphOpen
            // 
            this.graphOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.graphOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphOpen.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphOpen.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphOpen.Location = new System.Drawing.Point(635, 230);
            this.graphOpen.Name = "graphOpen";
            this.graphOpen.Size = new System.Drawing.Size(90, 29);
            this.graphOpen.TabIndex = 0;
            this.graphOpen.Text = "Browse...";
            this.graphOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.graphOpen.Click += new System.EventHandler(this.graphOpen_Click);
            // 
            // populationLabel
            // 
            this.populationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(290, 115);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(0, 13);
            this.populationLabel.TabIndex = 1;
            // 
            // graphLabel
            // 
            this.graphLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(290, 166);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(0, 13);
            this.graphLabel.TabIndex = 2;
            // 
            // populationTextBox
            // 
            this.populationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.populationTextBox.BackColor = System.Drawing.Color.Black;
            this.populationTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.populationTextBox.Location = new System.Drawing.Point(225, 330);
            this.populationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(400, 29);
            this.populationTextBox.TabIndex = 4;
            // 
            // graphTextBox
            // 
            this.graphTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphTextBox.BackColor = System.Drawing.Color.Black;
            this.graphTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphTextBox.Location = new System.Drawing.Point(225, 230);
            this.graphTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.graphTextBox.Name = "graphTextBox";
            this.graphTextBox.Size = new System.Drawing.Size(400, 29);
            this.graphTextBox.TabIndex = 5;
            // 
            // populationOpen
            // 
            this.populationOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.populationOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.populationOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.populationOpen.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationOpen.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.populationOpen.Location = new System.Drawing.Point(635, 330);
            this.populationOpen.Margin = new System.Windows.Forms.Padding(2);
            this.populationOpen.Name = "populationOpen";
            this.populationOpen.Size = new System.Drawing.Size(90, 29);
            this.populationOpen.TabIndex = 6;
            this.populationOpen.Text = "Browse...";
            this.populationOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.populationOpen.Click += new System.EventHandler(this.populationOpen_Click);
            // 
            // simulate
            // 
            this.simulate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulate.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.simulate.Location = new System.Drawing.Point(406, 450);
            this.simulate.Margin = new System.Windows.Forms.Padding(2);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(97, 27);
            this.simulate.TabIndex = 7;
            this.simulate.Text = "Simulate!";
            this.simulate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // selectGraph
            // 
            this.selectGraph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectGraph.AutoSize = true;
            this.selectGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.selectGraph.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGraph.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectGraph.Location = new System.Drawing.Point(360, 190);
            this.selectGraph.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectGraph.Name = "selectGraph";
            this.selectGraph.Size = new System.Drawing.Size(190, 21);
            this.selectGraph.TabIndex = 8;
            this.selectGraph.Text = "Select the Graph File";
            // 
            // selectPopulation
            // 
            this.selectPopulation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectPopulation.AutoSize = true;
            this.selectPopulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.selectPopulation.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPopulation.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectPopulation.Location = new System.Drawing.Point(333, 290);
            this.selectPopulation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectPopulation.Name = "selectPopulation";
            this.selectPopulation.Size = new System.Drawing.Size(234, 21);
            this.selectPopulation.TabIndex = 9;
            this.selectPopulation.Text = "Select the Population File";
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backToMenuButton.AutoSize = true;
            this.backToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMenuButton.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToMenuButton.Location = new System.Drawing.Point(728, 166);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(24, 25);
            this.backToMenuButton.TabIndex = 0;
            this.backToMenuButton.Text = "x";
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // tempBackground
            // 
            this.tempBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tempBackground.AutoSize = true;
            this.tempBackground.ForeColor = System.Drawing.Color.Black;
            this.tempBackground.Location = new System.Drawing.Point(150, 160);
            this.tempBackground.Name = "tempBackground";
            this.tempBackground.Size = new System.Drawing.Size(607, 351);
            this.tempBackground.TabIndex = 10;
            this.tempBackground.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaa\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            // 
            // tempBackgroundGlow1
            // 
            this.tempBackgroundGlow1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tempBackgroundGlow1.AutoSize = true;
            this.tempBackgroundGlow1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempBackgroundGlow1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempBackgroundGlow1.Location = new System.Drawing.Point(147, 157);
            this.tempBackgroundGlow1.Name = "tempBackgroundGlow1";
            this.tempBackgroundGlow1.Size = new System.Drawing.Size(613, 182);
            this.tempBackgroundGlow1.TabIndex = 12;
            this.tempBackgroundGlow1.Text = "aaaaaa|||aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaa\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            // 
            // tempBackgroundGlow2
            // 
            this.tempBackgroundGlow2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tempBackgroundGlow2.AutoSize = true;
            this.tempBackgroundGlow2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempBackgroundGlow2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempBackgroundGlow2.Location = new System.Drawing.Point(147, 332);
            this.tempBackgroundGlow2.Name = "tempBackgroundGlow2";
            this.tempBackgroundGlow2.Size = new System.Drawing.Size(613, 182);
            this.tempBackgroundGlow2.TabIndex = 13;
            this.tempBackgroundGlow2.Text = "aaaaaa|||aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaa\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            // 
            // daysSelect
            // 
            this.daysSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daysSelect.AutoSize = true;
            this.daysSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.daysSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.daysSelect.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysSelect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.daysSelect.Location = new System.Drawing.Point(344, 390);
            this.daysSelect.Name = "daysSelect";
            this.daysSelect.Size = new System.Drawing.Size(159, 21);
            this.daysSelect.TabIndex = 14;
            this.daysSelect.Text = "Days of Spread : ";
            // 
            // daysSpread
            // 
            this.daysSpread.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daysSpread.BackColor = System.Drawing.Color.Black;
            this.daysSpread.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daysSpread.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysSpread.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.daysSpread.Location = new System.Drawing.Point(508, 392);
            this.daysSpread.Margin = new System.Windows.Forms.Padding(2);
            this.daysSpread.Name = "daysSpread";
            this.daysSpread.Size = new System.Drawing.Size(71, 22);
            this.daysSpread.TabIndex = 15;
            this.daysSpread.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(909, 650);
            this.Controls.Add(this.daysSpread);
            this.Controls.Add(this.daysSelect);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.howToButton);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.howToStep);
            this.Controls.Add(this.howToTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.selectPopulation);
            this.Controls.Add(this.selectGraph);
            this.Controls.Add(this.simulate);
            this.Controls.Add(this.populationOpen);
            this.Controls.Add(this.graphTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.graphLabel);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.graphOpen);
            this.Controls.Add(this.tempBackground);
            this.Controls.Add(this.tempBackgroundGlow1);
            this.Controls.Add(this.tempBackgroundGlow2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoronaVirus Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label howToTitle;
        private System.Windows.Forms.Label howToStep;
        private System.Windows.Forms.Label simulateButton;
        private System.Windows.Forms.Label howToButton;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label graphOpen;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox graphTextBox;
        private System.Windows.Forms.Label populationOpen;
        private System.Windows.Forms.OpenFileDialog openPopulation;
        private System.Windows.Forms.Label simulate;
        private System.Windows.Forms.Label selectGraph;
        private System.Windows.Forms.Label selectPopulation;
        private System.Windows.Forms.Label backToMenuButton;
        private System.Windows.Forms.Label tempBackground;
        private System.Windows.Forms.Label tempBackgroundGlow1;
        private System.Windows.Forms.Label tempBackgroundGlow2;
        private System.Windows.Forms.Label daysSelect;
        private System.Windows.Forms.TextBox daysSpread;
    }
}

