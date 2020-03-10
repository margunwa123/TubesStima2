using System;
using System.Windows.Forms;
using System.Drawing;

namespace TubesStimaVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            howToTitle.Hide();
            howToStep.Hide();
            label1.Hide();
            title.Show();
            playButton.Show();
            howToButton.Show();
            exitButton.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            howToTitle.Hide();
            howToStep.Hide();
            label1.Hide();
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ShowGraph = new Form2();
            ShowGraph.ShowDialog();
            this.Close();
        }

        private void howToButton_Click(object sender, EventArgs e)
        {
            title.Hide();
            playButton.Hide();
            howToButton.Hide();
            exitButton.Hide();
            groupBox1.Show();
            label1.Show();
            howToTitle.Show();
            howToStep.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
