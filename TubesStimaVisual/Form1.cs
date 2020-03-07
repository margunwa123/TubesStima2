using System;
using System.IO;
using System.Windows.Forms;

namespace TubesStimaVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString().Substring(9);
            graphPath.Text = @"C:\Users\Asus\Desktop\Semester_IV\Tubes & tucil\Stima\TubesStima2\TubesStimaVisual\assets\Graph.txt";
            populationPath.Text = @"C:\Users\Asus\Desktop\Semester_IV\Tubes & tucil\Stima\TubesStima2\TubesStimaVisual\assets\Populasi.txt";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime Date = DateTime.Now;
            clock.Text = Date.ToString().Substring(9);
        }

        private void Clock_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            try
            {
                PopulationReader population = new PopulationReader(populationPath.Text);
                GraphReader relation = new GraphReader(graphPath.Text);
                Graph probability = new Graph(population, relation);
            }
            catch (DirectoryNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
