using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TubesStimaVisual.src.FileReaderClass;
using TubesStimaVisual.src.GraphClass;

namespace TubesStimaVisual
{
    public partial class Form1 : Form
    {
        private Graph populationAndProbability;
        private List<string> citiesDescription;
        private int iterate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString().Substring(9);
            graphPath.Text = @"C:\Users\Asus\Desktop\Semester_IV\Tubes & tucil\Stima\TubesStima2\TubesStimaVisual\assets\Graph.txt";
            populationPath.Text = @"C:\Users\Asus\Desktop\Semester_IV\Tubes & tucil\Stima\TubesStima2\TubesStimaVisual\assets\Populasi.txt";
            iterate = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            string timeInHourMinuteSecondAMPM = Date.ToString().Substring(10);
            clock.Text = timeInHourMinuteSecondAMPM;
        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            try
            {
                populationAndProbability = new Graph(populationPath.Text, graphPath.Text);
                citiesDescription = populationAndProbability.infoGraphInListOfString();
            }
            catch (DirectoryNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void AButton_Click(object sender, EventArgs e)
        {
            try { 
                aLabel.Text = citiesDescription[iterate];
                iterate++;
            } catch (ArgumentOutOfRangeException indexOutOfRangeException)
            {
                iterate = 0;
                aLabel.Text = citiesDescription[iterate];
            }
        }
    }
}
