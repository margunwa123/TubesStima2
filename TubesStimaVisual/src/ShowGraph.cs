using System;
using System.Linq;
using System.Windows.Forms;
using TubesStimaVisual.src.FileReaderClass;
using TubesStimaVisual.src.GraphClass;

namespace TubesStimaVisual
{
    public partial class Form2 : Form
    {
        private Graph populationAndProbability;
        private Microsoft.Msagl.Drawing.Graph graph;
        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        public Form2(string populationText, string graphText, int days)
        {
            if(days < 0)
            {
                throw new IndexOutOfRangeException("Day harus lebih besar atau sama dengan 0");
            }
            InitializeComponent();
            populationAndProbability = new Graph(populationText, graphText);
            populationAndProbability.solveBFS(days);
            viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            graph = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach(var(node, graphElement) in populationAndProbability.getNodes().Select(T => (T.Key, T.Value)))
            {
                
                graph.AddNode(Char.ToString(node));
                Microsoft.Msagl.Drawing.Node temp = graph.FindNode(Char.ToString(node));
                temp.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
                if(graphElement.timeInfected != GraphElement.WAKTUMASYARAKATBELUMTERINFEKSI)
                {
                    temp.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                }
                foreach (TrailElement trailElement in graphElement.trails)
                {
                    if(graphElement.cekPenyebaranKe(trailElement.trail) > 1)
                    {
                        graph.AddEdge(Char.ToString(node), Char.ToString(trailElement.trail)).Attr.Color = Microsoft.Msagl.Drawing.Color.DarkBlue;
                    }
                    else
                    {
                        graph.AddEdge(Char.ToString(node), Char.ToString(trailElement.trail)).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    }
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
    }
}
