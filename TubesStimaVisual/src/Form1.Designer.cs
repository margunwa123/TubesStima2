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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.simulate = new System.Windows.Forms.Button();
            this.graphPath = new System.Windows.Forms.TextBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.populationPath = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.showGraph = new System.Windows.Forms.Button();
            this.aLabel = new System.Windows.Forms.Label();
            this.aButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Kozuka Mincho Pro R", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(127, 113);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(565, 36);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome To CoronaVirus Spread Simulator";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simulate
            // 
            this.simulate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.simulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulate.Location = new System.Drawing.Point(405, 365);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(121, 60);
            this.simulate.TabIndex = 1;
            this.simulate.Text = "Simulate!";
            this.simulate.UseVisualStyleBackColor = false;
            this.simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // graphPath
            // 
            this.graphPath.Location = new System.Drawing.Point(264, 319);
            this.graphPath.Name = "graphPath";
            this.graphPath.Size = new System.Drawing.Size(262, 22);
            this.graphPath.TabIndex = 2;
            this.graphPath.Text = "./assets/Graph.txt";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(296, 238);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(209, 17);
            this.subtitle.TabIndex = 3;
            this.subtitle.Text = "Enter your population path here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your graph file path here";
            // 
            // populationPath
            // 
            this.populationPath.Location = new System.Drawing.Point(264, 265);
            this.populationPath.Name = "populationPath";
            this.populationPath.Size = new System.Drawing.Size(262, 22);
            this.populationPath.TabIndex = 5;
            this.populationPath.Text = "./assets/Populasi.txt";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.Location = new System.Drawing.Point(632, 412);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(156, 29);
            this.clock.TabIndex = 6;
            this.clock.Text = "00:00:00 AM";
            this.clock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // showGraph
            // 
            this.showGraph.Location = new System.Drawing.Point(264, 365);
            this.showGraph.Name = "showGraph";
            this.showGraph.Size = new System.Drawing.Size(121, 60);
            this.showGraph.TabIndex = 7;
            this.showGraph.Text = "Starting Graph";
            this.showGraph.UseVisualStyleBackColor = true;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(585, 184);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(46, 17);
            this.aLabel.TabIndex = 8;
            this.aLabel.Text = "label2";
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(564, 304);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(166, 37);
            this.aButton.TabIndex = 9;
            this.aButton.Text = "Check Graph";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.showGraph);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.populationPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.graphPath);
            this.Controls.Add(this.simulate);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button simulate;
        private System.Windows.Forms.TextBox graphPath;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox populationPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button showGraph;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Button aButton;
    }
}

