using System;
using System.Windows.Forms;
using TubesStimaVisual.src.GraphClass;

namespace TubesStimaVisual
{
    public partial class Form1 : Form
    {
        private Graph populationAndProbability;
        private string populationText;
        private string graphText;
        private int days;
        Microsoft.Msagl.Drawing.Graph graph;
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        public Form1()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            graphTextBox.Text = "Type here";
            populationTextBox.Text = "Type here";
        }
        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            howToTitle.Hide();
            howToStep.Hide();
            backToMenuButton.Hide();
            selectGraph.Hide();
            selectPopulation.Hide();
            populationOpen.Hide();
            graphOpen.Hide();
            populationTextBox.Hide();
            graphTextBox.Hide();
            simulate.Hide();
            tempBackgroundGlow1.Hide();
            tempBackgroundGlow2.Hide();
            tempBackground.Hide();
            daysSelect.Hide();
            daysSpread.Hide();
            title.Show();
            subtitle.Show();
            simulateButton.Show();
            howToButton.Show();
            exitButton.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            howToTitle.Hide();
            howToStep.Hide();
            backToMenuButton.Hide();
            selectGraph.Hide();
            selectPopulation.Hide();
            populationOpen.Hide();
            graphOpen.Hide();
            populationTextBox.Hide();
            graphTextBox.Hide();
            simulate.Hide();
            tempBackgroundGlow1.Hide();
            tempBackgroundGlow2.Hide();
            tempBackground.Hide();
            daysSelect.Hide();
            daysSpread.Hide();
        }
        private void simulateButton_Click(object sender, EventArgs e)
        {
            tempBackgroundGlow1.Show();
            tempBackgroundGlow2.Show();
            tempBackground.Show();
            selectGraph.Show();
            selectPopulation.Show();
            populationOpen.Show();
            graphOpen.Show();
            populationTextBox.Show();
            graphTextBox.Show();
            simulate.Show();
            backToMenuButton.Show();
            daysSelect.Show();
            daysSpread.Show();
            title.Hide();
            subtitle.Hide();
            simulateButton.Hide();
            howToButton.Hide();
            exitButton.Hide();
            howToTitle.Hide();
            howToStep.Hide();
        }

        private void howToButton_Click(object sender, EventArgs e)
        {
            tempBackgroundGlow1.Show();
            tempBackgroundGlow2.Show();
            tempBackground.Show();
            backToMenuButton.Show();
            howToTitle.Show();
            howToStep.Show();
            title.Hide();
            subtitle.Hide();
            simulateButton.Hide();
            howToButton.Hide();
            exitButton.Hide();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void graphOpen_Click(object sender, EventArgs e)
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
        private void populationOpen_Click(object sender, EventArgs e)
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
            graphText = graphTextBox.Text;
            populationText = populationTextBox.Text;
            int check = 0;
            try
            {
                populationAndProbability = new Graph(populationText, graphText);
                populationAndProbability.solveBFS(5);
            }
            catch (ArgumentNullException argumentNullException)
            {
                check = 1;
                MessageBox.Show(argumentNullException.Message);
            }
            catch (ArgumentOutOfRangeException argumentException)
            {
                check = 1;
                MessageBox.Show(argumentException.Message);
            }
            if (check == 0)
            {
                days = Convert.ToInt32(daysSpread.Text);
                Form2 showGraph = new Form2(populationText, graphText, days);
                showGraph.ShowDialog();
            }
        }
    }
}
