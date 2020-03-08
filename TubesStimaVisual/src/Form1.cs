using System;
using System.IO;
using System.Windows.Forms;
using TubesStimaVisual.src.FileReaderClass;
using TubesStimaVisual.src.GraphClass;

namespace TubesStimaVisual
{
    public partial class Form1 : Form
    {
        private Graph populationAndProbability;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString().Substring(9);
            graphPath.Text = @"C:\Users\Asus\Desktop\Semester_IV\Tubes & tucil\Stima\TubesStima2\TubesStimaVisual\assets\Graph.txt";
            populationPath.Text = @"C:\Users\Asus\Desktop\Semester_IV\Tubes & tucil\Stima\TubesStima2\TubesStimaVisual\assets\Populasi.txt";
            try
            {
                PopulationReader population = new PopulationReader(populationPath.Text);
                GraphReader relation = new GraphReader(graphPath.Text);
                populationAndProbability = new Graph(population, relation);
            }
            catch (DirectoryNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            string timeInHourMinuteSecondAMPM = Date.ToString().Substring(9);
            clock.Text = timeInHourMinuteSecondAMPM;
        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            populationAndProbability.printInfo();
        }
    }
}
