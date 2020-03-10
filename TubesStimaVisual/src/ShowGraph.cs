using System;
using System.Collections.Generic;
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
        private List<string> citiesDescription;
        private int iterate;
        public Form2()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = @"E:\Evan\Kuliah\Tugas\Semester 4\IF-2211 Strategi Algoritma\Tubes 2\TubesStima2\TubesStimaVisual\assets\Graph.txt";
            label1.Text = @"E:\Evan\Kuliah\Tugas\Semester 4\IF - 2211 Strategi Algoritma\Tubes 2\TubesStima2\TubesStimaVisual\assets\Populasi.txt";
            iterate = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populationAndProbability = new Graph(label1.Text, label2.Text);
            citiesDescription = populationAndProbability.infoGraphInListOfString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "A");
            graph.AddEdge("B", "C");
            graph.AddEdge("C", "A");
            graph.AddEdge("C", "B");

            Microsoft.Msagl.Drawing.Node a = graph.FindNode("A");
            a.Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
            a.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            Microsoft.Msagl.Drawing.Node b = graph.FindNode("B");
            b.Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
            b.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            Controls.Add(viewer);
            ResumeLayout();
        }
    }
}
