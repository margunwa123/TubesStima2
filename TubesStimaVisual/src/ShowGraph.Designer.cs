namespace TubesStimaVisual
{
    partial class Form2
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
            this.graphOpen = new System.Windows.Forms.Button();
            this.populationLabel = new System.Windows.Forms.Label();
            this.graphLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.graphTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.simulate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // graphOpen
            // 
            this.graphOpen.Location = new System.Drawing.Point(381, 157);
            this.graphOpen.Margin = new System.Windows.Forms.Padding(4);
            this.graphOpen.Name = "graphOpen";
            this.graphOpen.Size = new System.Drawing.Size(100, 28);
            this.graphOpen.TabIndex = 0;
            this.graphOpen.Text = "Choose";
            this.graphOpen.UseVisualStyleBackColor = true;
            this.graphOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(387, 142);
            this.populationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(0, 17);
            this.populationLabel.TabIndex = 1;
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(387, 183);
            this.graphLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(0, 17);
            this.graphLabel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(259, 203);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 22);
            this.populationTextBox.TabIndex = 4;
            // 
            // graphTextBox
            // 
            this.graphTextBox.Location = new System.Drawing.Point(259, 163);
            this.graphTextBox.Name = "graphTextBox";
            this.graphTextBox.Size = new System.Drawing.Size(100, 22);
            this.graphTextBox.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Choose";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // simulate
            // 
            this.simulate.Location = new System.Drawing.Point(562, 162);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(75, 23);
            this.simulate.TabIndex = 7;
            this.simulate.Text = "button4";
            this.simulate.UseVisualStyleBackColor = true;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a Graph File";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simulate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.graphTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.graphLabel);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.graphOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button graphOpen;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox graphTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openPopulation;
        private System.Windows.Forms.Button simulate;
        private System.Windows.Forms.Label label1;
    }
}