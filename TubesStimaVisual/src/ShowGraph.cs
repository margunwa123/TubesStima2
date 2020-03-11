using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesStimaVisual.src.FileReaderClass;
using TubesStimaVisual.src.GraphClass;

namespace TubesStimaVisual
{
    public partial class Form2 : Form
    {
        private Graph populationAndProbability;
        private string populationText;
        private string graphText;
        Microsoft.Msagl.Drawing.Graph graph;
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        public Form2()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            graphTextBox.Text = @"E:\Evan\Kuliah\Tugas\Semester 4\IF-2211 Strategi Algoritma\Tubes 2\TubesStima2\TubesStimaVisual\assets\Graph.txt";
            populationTextBox.Text = @"E:\Evan\Kuliah\Tugas\Semester 4\IF-2211 Strategi Algoritma\Tubes 2\TubesStima2\TubesStimaVisual\assets\Populasi.txt";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openGraph = new OpenFileDialog();
            openGraph.Title = "Select the Graph File";
            openGraph.Filter = "Text Files (*.txt) | *.txt";
            DialogResult dr = openGraph.ShowDialog();
            if (dr == DialogResult.OK)
            {
                graphText = openGraph.FileName;
                graphTextBox.Text = graphText;
            }
        }

        private void showCurrentGraph_Click(object sender, EventArgs e)
        {
            viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            graph = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach(var(node, graphElement) in populationAndProbability.getNodes().Select(T => (T.Key, T.Value)))
            {
                
                graph.AddNode(Char.ToString(node));
                Microsoft.Msagl.Drawing.Node temp = graph.FindNode(Char.ToString(node));
                temp.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;

                if (graphElement.timeInfected != GraphElement.WAKTUMASYARAKATBELUMTERINFEKSI)
                {
                    temp.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                }
                foreach(TrailElement trailElement in graphElement.trails)
                {
                    graph.AddEdge(Char.ToString(node), Char.ToString(trailElement.trail));
                }
            }

            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            Controls.Add(viewer);
            ResumeLayout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPopulation = new OpenFileDialog();
            openPopulation.Title = "Select the Population File";
            openPopulation.Filter = "Text Files (*.txt) | *.txt";
            DialogResult dr = openPopulation.ShowDialog();
            if (dr == DialogResult.OK)
            {
                populationText = openPopulation.FileName;
                populationTextBox.Text = populationText;
            }
        }

        private void simulate_Click(object sender, EventArgs e)
        {
            try
            {
                populationAndProbability = new Graph(populationText, graphText);
                populationAndProbability.solveBFS(5);
            }
            catch (ArgumentNullException argumentNullException)
            {
                MessageBox.Show(argumentNullException.Message);
            }
        }
    }
}
