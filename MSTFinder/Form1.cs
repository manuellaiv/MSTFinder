using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.Core.ProjectionSolver;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Msagl.Core.Layout;
using System.Globalization;
using Microsoft.Msagl.Routing.Rectilinear.Nudging;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Xml.Linq;
using Microsoft.Msagl.GraphmapsWithMesh;

namespace MSTFinder
{
    public partial class Form1 : Form
    {
        private Graph g;
        //create a viewer object
        private GViewer viewer;
        //create a graph object  
        private Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

        public Form1()
        {
            InitializeComponent();
        }

        public void visualize()
        {
            //create a viewer object
            GViewer viewer = new GViewer();
            //create a graph object  
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            


            //bind the graph to the viewer  
            viewer.Graph = graph;
            //associate the viewer with the form  
            panel1.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(viewer);
            panel1.ResumeLayout();
        }

        private void button_search__Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_filename.Text = ofd.FileName;
            }
        }

        private void button_visualize_Click(object sender, EventArgs e)
        {
            try
            {
                g = new Graph(textBox_filename.Text);
                if (Path.GetExtension(textBox_filename.Text) == "")
                {

                }

                else if (Path.GetExtension(textBox_filename.Text) != ".txt")
                {
                    labelNotif.Text = "File type not valid.";
                }
                else
                {
                    //create a viewer object
                    viewer = new GViewer();
                    //create a graph object  
                    graph = new Microsoft.Msagl.Drawing.Graph("graph");


                    // generate nodes in listBoxN1 and listBoxN2
                    listBoxN1.Items.Clear();
                    listBoxN2.Items.Clear();
                    listBoxDelNode.Items.Clear();
                    labelNotif.Text = "";

                    // load nodes
                    g = new Graph(textBox_filename.Text);
                    foreach (Node node in g.getNodes())
                    {
                        graph.AddNode(node.getN().ToString());
                        listBoxN1.Items.Add(node.getN().ToString());
                        listBoxN2.Items.Add(node.getN().ToString());
                        listBoxDelNode.Items.Add(node.getN().ToString());
                    }

                    // load edges
                    foreach (Edge edge in g.getEdges())
                    {
                        if (!connectedNodes(graph, edge.getN1().getN().ToString(), edge.getN2().getN().ToString()))
                        {
                            graph.AddEdge(edge.getN1().getN().ToString(), edge.getWeight().ToString(), edge.getN2().getN().ToString());
                        }
                    }

                    panel1.Controls.Clear();
                    //bind the graph to the viewer  
                    viewer.Graph = graph;
                    //associate the viewer with the form  
                    panel1.SuspendLayout();
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel1.Controls.Add(viewer);
                    panel1.ResumeLayout();
                }
            }
            catch(InvalidDataException err)
            {
                labelNotif.Text = err.Message;
            }
            catch (Exception err)
            {
                labelNotif.Text = err.Message;
            }

            
        }

        private bool connectedNodes(Microsoft.Msagl.Drawing.Graph graph, string n1, string n2)
        {
            bool connected = false;
            Microsoft.Msagl.Drawing.Node node1 = graph.FindNode(n1);
            Microsoft.Msagl.Drawing.Node node2 = graph.FindNode(n2);
            foreach (Microsoft.Msagl.Drawing.Edge edge in node1.OutEdges)
            {
                if (edge.Target == n2)
                {
                    connected = true;
                    break;
                }
            }
            return connected;
        }

        private void refreshGraph()
        {
            //create a viewer object
            viewer = new GViewer();
            //create a graph object  
            graph = new Microsoft.Msagl.Drawing.Graph("graph");

            listBoxN1.Items.Clear();
            listBoxN2.Items.Clear();
            listBoxDelNode.Items.Clear();
            labelNotif.Text = "";

            // load nodes
            foreach (Node node in g.getNodes())
            {
                graph.AddNode(node.getN().ToString());
                listBoxN1.Items.Add(node.getN().ToString());
                listBoxN2.Items.Add(node.getN().ToString());
                listBoxDelNode.Items.Add(node.getN().ToString());
            }

            // load edges
            foreach (Edge edge in g.getEdges())
            {
                if (!connectedNodes(graph, edge.getN1().getN().ToString(), edge.getN2().getN().ToString())){
                    graph.AddEdge(edge.getN1().getN().ToString(), edge.getWeight().ToString(), edge.getN2().getN().ToString());
                }
            }

            panel1.Controls.Clear();
            //bind the graph to the viewer  
            viewer.Graph = graph;
            //associate the viewer with the form  
            panel1.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(viewer);
            panel1.ResumeLayout();
        }

        private void buttonAddNode_Click(object sender, EventArgs e)
        {
            if (textBox_addNode.Text != "")
            {
                int newnode;
                bool result = Int32.TryParse(textBox_addNode.Text, out newnode);
                if (!result)
                {
                    labelNotif.Text = "Can't parse node's name.";
                }
                else
                {
                    g.addNode(new Node(newnode));
                    refreshGraph();
                }
                    
            }
        }

        private void buttonDelNode_Click(object sender, EventArgs e)
        {
            int selected;
            bool result = Int32.TryParse(listBoxDelNode.GetItemText(listBoxDelNode.SelectedItem), out selected);

            g.deleteNode(selected);
            refreshGraph();
        }

        private void buttonAddEdge_Click(object sender, EventArgs e)
        {
            int N1, N2;
            double weight;
            bool result1 = Int32.TryParse(listBoxN1.GetItemText(listBoxN1.SelectedItem), out N1);
            bool result2 = Int32.TryParse(listBoxN2.GetItemText(listBoxN2.SelectedItem), out N2);
            weight = System.Convert.ToDouble(textBoxWeight.Text, CultureInfo.InvariantCulture);

            if (result1 && result2)
            {
                g.addEdge(N1, N2, weight);
                refreshGraph();
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            if (radioButton_Prim.Checked && g != null)
            {
                // load all
                //create a viewer object
                viewer = new GViewer();
                //create a graph object  
                graph = new Microsoft.Msagl.Drawing.Graph("graph");

                listBoxN1.Items.Clear();
                listBoxN2.Items.Clear();
                listBoxDelNode.Items.Clear();
                labelNotif.Text = "";

                // load nodes
                foreach (Node node in g.getNodes())
                {
                    graph.AddNode(node.getN().ToString());
                    listBoxN1.Items.Add(node.getN().ToString());
                    listBoxN2.Items.Add(node.getN().ToString());
                    listBoxDelNode.Items.Add(node.getN().ToString());
                }

                // load edges
                foreach (Edge edge in g.getEdges())
                {
                    if (!connectedNodes(graph, edge.getN1().getN().ToString(), edge.getN2().getN().ToString()))
                    {
                        graph.AddEdge(edge.getN1().getN().ToString(), edge.getWeight().ToString(), edge.getN2().getN().ToString());
                    }
                }

                panel1.Controls.Clear();
                //bind the graph to the viewer  
                viewer.Graph = graph;
                //associate the viewer with the form  
                panel1.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                panel1.Controls.Add(viewer);
                panel1.ResumeLayout();

                // load Prim
                foreach (Microsoft.Msagl.Drawing.Edge edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                }

                List<Edge> edges = new List<Edge>();
                edges = g.Prim();
                foreach (Edge ed in edges)
                {
                    foreach (Microsoft.Msagl.Drawing.Edge edge in graph.Edges)
                    {
                        if (edge.Source == ed.getN1().getN().ToString() && edge.Target == ed.getN2().getN().ToString() || edge.Source == ed.getN2().getN().ToString() && edge.Target == ed.getN1().getN().ToString())
                        {
                            edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        }
                    }
                }
            }
            if (radioButton_Kruskal.Checked && g != null)
            {
                // load all
                //create a viewer object
                viewer = new GViewer();
                //create a graph object  
                graph = new Microsoft.Msagl.Drawing.Graph("graph");

                listBoxN1.Items.Clear();
                listBoxN2.Items.Clear();
                listBoxDelNode.Items.Clear();
                labelNotif.Text = "";

                // load nodes
                foreach (Node node in g.getNodes())
                {
                    graph.AddNode(node.getN().ToString());
                    listBoxN1.Items.Add(node.getN().ToString());
                    listBoxN2.Items.Add(node.getN().ToString());
                    listBoxDelNode.Items.Add(node.getN().ToString());
                }

                // load edges
                foreach (Edge edge in g.getEdges())
                {
                    if (!connectedNodes(graph, edge.getN1().getN().ToString(), edge.getN2().getN().ToString()))
                    {
                        graph.AddEdge(edge.getN1().getN().ToString(), edge.getWeight().ToString(), edge.getN2().getN().ToString());
                    }
                }

                panel1.Controls.Clear();
                //bind the graph to the viewer  
                viewer.Graph = graph;
                //associate the viewer with the form  
                panel1.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                panel1.Controls.Add(viewer);
                panel1.ResumeLayout();

                // load Kruskal
                foreach (Microsoft.Msagl.Drawing.Edge edge in graph.Edges)
                {
                    edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;

                }

                List<Edge> edges = new List<Edge>();
                edges = g.Kruskal();
                foreach (Edge ed in edges)
                {
                    foreach (Microsoft.Msagl.Drawing.Edge edge in graph.Edges)
                    {
                        if (edge.Source == ed.getN1().getN().ToString() && edge.Target == ed.getN2().getN().ToString() || edge.Source == ed.getN2().getN().ToString() && edge.Target == ed.getN1().getN().ToString())
                        {
                            edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        }
                    }
                }
            }
        }

        private void buttonMakeCluster_Click(object sender, EventArgs e)
        {
            int N;
            bool result = Int32.TryParse(textBoxN.Text, out N);
            if (result && (N < g.getNodes().Count && N > 1))
            {
                if (radioButton_Prim.Checked)
                {
                    // load all
                    //create a viewer object
                    GViewer viewer2 = new GViewer();
                    //create a graph object  
                    Microsoft.Msagl.Drawing.Graph graph2 = new Microsoft.Msagl.Drawing.Graph("graph");

                    listBoxN1.Items.Clear();
                    listBoxN2.Items.Clear();
                    listBoxDelNode.Items.Clear();
                    labelNotif.Text = "";

                    // load nodes
                    foreach (Node node in g.getNodes())
                    {
                        graph2.AddNode(node.getN().ToString());
                        listBoxN1.Items.Add(node.getN().ToString());
                        listBoxN2.Items.Add(node.getN().ToString());
                        listBoxDelNode.Items.Add(node.getN().ToString());
                    }

                    // load edges
                    foreach (Edge edge in g.getEdges())
                    {
                        if (!connectedNodes(graph2, edge.getN1().getN().ToString(), edge.getN2().getN().ToString()))
                        {
                            graph2.AddEdge(edge.getN1().getN().ToString(), edge.getWeight().ToString(), edge.getN2().getN().ToString());
                        }
                    }

                    // load Prim
                    foreach (Microsoft.Msagl.Drawing.Edge edge in graph2.Edges)
                    {
                        edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    }

                    List<Edge> edges = new List<Edge>();
                    edges = g.Prim();
                    foreach (Edge ed in edges)
                    {
                        foreach (Microsoft.Msagl.Drawing.Edge edge in graph2.Edges)
                        {
                            if (edge.Source == ed.getN1().getN().ToString() && edge.Target == ed.getN2().getN().ToString() || edge.Source == ed.getN2().getN().ToString() && edge.Target == ed.getN1().getN().ToString())
                            {
                                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            }
                        }
                    }

                    // cut edges
                    edges.Sort();
                    List<Microsoft.Msagl.Drawing.Edge> edgesToRemove = new List<Microsoft.Msagl.Drawing.Edge>();
                    for (int i = 1; i < N; i++)
                    {
                        Edge cut = edges[edges.Count - i];

                        foreach (Microsoft.Msagl.Drawing.Edge edge in graph2.Edges)
                        {
                            if (edge.Source == cut.getN1().getN().ToString() && edge.Target == cut.getN2().getN().ToString() || edge.Source == cut.getN2().getN().ToString() && edge.Target == cut.getN1().getN().ToString())
                            {
                                edgesToRemove.Add(edge);
                            }
                        }
                    }

                    foreach (Microsoft.Msagl.Drawing.Edge edgeToRemove in edgesToRemove)
                    {
                        graph2.RemoveEdge(edgeToRemove);
                    }

                    panel2.Controls.Clear();
                    //bind the graph to the viewer  
                    viewer2.Graph = graph2;
                    //associate the viewer with the form  
                    panel2.SuspendLayout();
                    viewer2.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel2.Controls.Add(viewer2);
                    panel2.ResumeLayout();

                }
                if (radioButton_Kruskal.Checked)
                {
                    // load all
                    //create a viewer object
                    GViewer viewer2 = new GViewer();
                    //create a graph object  
                    Microsoft.Msagl.Drawing.Graph graph2 = new Microsoft.Msagl.Drawing.Graph("graph");

                    listBoxN1.Items.Clear();
                    listBoxN2.Items.Clear();
                    listBoxDelNode.Items.Clear();
                    labelNotif.Text = "";

                    // load nodes
                    foreach (Node node in g.getNodes())
                    {
                        graph2.AddNode(node.getN().ToString());
                        listBoxN1.Items.Add(node.getN().ToString());
                        listBoxN2.Items.Add(node.getN().ToString());
                        listBoxDelNode.Items.Add(node.getN().ToString());
                    }

                    // load edges
                    foreach (Edge edge in g.getEdges())
                    {
                        if (!connectedNodes(graph2, edge.getN1().getN().ToString(), edge.getN2().getN().ToString()))
                        {
                            graph2.AddEdge(edge.getN1().getN().ToString(), edge.getWeight().ToString(), edge.getN2().getN().ToString());
                        }
                    }

                    // load Kruskal
                    foreach (Microsoft.Msagl.Drawing.Edge edge in graph2.Edges)
                    {
                        edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;

                    }

                    List<Edge> edges = new List<Edge>();
                    edges = g.Kruskal();
                    foreach (Edge ed in edges)
                    {
                        foreach (Microsoft.Msagl.Drawing.Edge edge in graph2.Edges)
                        {
                            if (edge.Source == ed.getN1().getN().ToString() && edge.Target == ed.getN2().getN().ToString() || edge.Source == ed.getN2().getN().ToString() && edge.Target == ed.getN1().getN().ToString())
                            {
                                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            }
                        }
                    }

                    // cut edges
                    edges.Sort();
                    List<Microsoft.Msagl.Drawing.Edge> edgesToRemove = new List<Microsoft.Msagl.Drawing.Edge>();
                    for (int i = 1; i < N; i++)
                    {
                        Edge cut = edges[edges.Count - i];

                        foreach (Microsoft.Msagl.Drawing.Edge edge in graph2.Edges)
                        {
                            if (edge.Source == cut.getN1().getN().ToString() && edge.Target == cut.getN2().getN().ToString() || edge.Source == cut.getN2().getN().ToString() && edge.Target == cut.getN1().getN().ToString())
                            {
                                edgesToRemove.Add(edge);
                            }
                        }
                    }

                    foreach (Microsoft.Msagl.Drawing.Edge edgeToRemove in edgesToRemove)
                    {
                        graph2.RemoveEdge(edgeToRemove);
                    }

                    panel2.Controls.Clear();
                    //bind the graph to the viewer  
                    viewer2.Graph = graph2;
                    //associate the viewer with the form  
                    panel2.SuspendLayout();
                    viewer2.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel2.Controls.Add(viewer2);
                    panel2.ResumeLayout();
                }
            }
            
        }
    }
}
