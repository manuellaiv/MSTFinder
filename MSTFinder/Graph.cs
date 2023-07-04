using System.Collections.Generic;
using System.Globalization;

namespace MSTFinder{
    class Graph{
        private List<Node> nodes;
        private List<Edge> edges;

        public Graph(string filename){
            nodes = new List<Node>();
            edges = new List<Edge>();
            readGraf(filename);
        }

        public Graph(List<Node> nodes, List<Edge> edges){
            this.nodes = nodes;
            this.edges = edges;
        }

        public Graph(){
            nodes = new List<Node>();
            edges = new List<Edge>();
        }

        public List<Node> getNodes(){
            return this.nodes;
        }

        public void setNodes(List<Node> nodes){
            this.nodes = nodes;
        }

        public List<Edge> getEdges(){
            return this.edges;
        }

        public void setEdges(List<Edge> edges){
            this.edges = edges;
        }

        public void addNode(Node node){
            nodes.Add(node);
        }

        public void addEdge(int n1, int n2, int weight){
            int i1 = -1;
            int i2 = -1;
            for(int i = 0; i < nodes.Count; i++){
                if (nodes[i].getN() == n1){
                    i1 = i;
                }
                if (nodes[i].getN() == n2){
                    i2 = i;
                }
            }

            Edge e1 = new Edge(nodes[i1], nodes[i2], weight);
            Edge e2 = new Edge(nodes[i2], nodes[i1], weight);
            edges.Add(e1);
            edges.Add(e2);
        }

        public void deleteNode(int n){
            for(int i = 0; i < nodes.Count; i++){
                if (nodes[i].getN() == n){
                    nodes.RemoveAt(i);
                }
            }

            for(int i = 0; i < nodes.Count; i++){
                nodes[i].getNeighbor().Remove(n);
            }

            for(int i = 0; i < edges.Count; i++){
                if (edges[i].getN1().getN() == n || edges[i].getN2().getN() == n){
                    edges.RemoveAt(i);
                }
            }
        }

        public void deleteEdge(int n1, int n2){
            for(int i = 0; i < edges.Count; i++){
                if ((edges[i].getN1().getN() == n1 && edges[i].getN2().getN() == n2) || (edges[i].getN1().getN() == n2 && edges[i].getN2().getN() == n1)){
                    edges.RemoveAt(i);
                }
            }
        }

        public bool isValidMatrix(double[,] matrix, int n){
            bool valid = true;

            // checking reflextion property
            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    if (matrix[i,j] != matrix[j,i]){
                        valid = false;
                    }
                }
            }

            // checking diagonal values
            for(int i = 0; i < n; i++){
                if (matrix[i,i] != 0){
                    valid = false;
                }
            }

            return valid;
        }

        public void readGraf(string filename){
            using (StreamReader reader_test = new StreamReader(filename)){
                // testing file validity
                string line = reader_test.ReadLine();
                if (line == null) throw new InvalidDataException("File not valid.");

                string[] lines = line.Split(' ');
                int n = lines.Length;

                int h = 0;
                bool valid = true;
                while (valid && line != null){
                    lines = line.Split(' ');
                    h++;
                    if (lines.Length != n){
                        valid = false;
                    }
                    line = reader_test.ReadLine();
                }
                if ((n != h) || !valid) throw new InvalidDataException("Graph not valid.");

                // reading file to a matrix
                StreamReader reader = new StreamReader(filename);
                double[,] matrix = new double[n,n];
                for(int i = 0; i < n; i++){
                    lines = reader.ReadLine().Split(' ');
                    for(int j = 0; j < n; j++){
                        matrix[i,j] = Convert.ToDouble(lines[j], CultureInfo.InvariantCulture);
                    }
                }

                if (!isValidMatrix(matrix,n)) throw new InvalidDataException("Matrix not valid.");

                // add matrix to graph
                // add nodes
                for(int i = 0; i < n; i++){
                    nodes.Add(new Node(i));
                }

                // add edges
                for(int i = 0; i < n; i++){
                    for(int j = 0; j < n; j++){
                        if (matrix[i,j] != 0){
                            edges.Add(new Edge(nodes[i], nodes[j], matrix[i,j]));
                            nodes[i].addNeighbor(j);
                            nodes[j].addNeighbor(i);
                        }
                    }
                }
            }
        }

        public bool isConnected(Node n1, Node n2){
            int i = 0;
            bool found = false;
            while(i < edges.Count && !found){
                if (edges[i].getN1() == n1 && edges[i].getN2() == n2){
                    found = true;
                }
                else{
                    i++;
                }
            }
            return found;
        }

        public List<Edge> Prim(){
            List<Edge> mst = new List<Edge>();
            HashSet<Node> visited = new HashSet<Node>();

            if (nodes.Count == 0 || edges.Count == 0){
                return mst;
            }

            Node startNode = nodes[0];

            visited.Add(startNode);

            while (visited.Count < nodes.Count){
                Edge minEdge = null;
                foreach (Edge edge in edges){
                    if (visited.Contains(edge.getN1()) && !visited.Contains(edge.getN2())){
                        if (minEdge == null || edge.getWeight() < minEdge.getWeight()){
                            minEdge = edge;
                        }
                    }
                    else if (visited.Contains(edge.getN2()) && !visited.Contains(edge.getN1())){
                        if (minEdge == null || edge.getWeight() < minEdge.getWeight()){
                            minEdge = edge;
                        }
                    }
                }

                if (minEdge != null){
                    mst.Add(minEdge);

                    if (!visited.Contains(minEdge.getN1())){
                        visited.Add(minEdge.getN1());
                    }

                    if (!visited.Contains(minEdge.getN2())){
                        visited.Add(minEdge.getN2());
                    }
                }
                else{
                    break;
                }
            }

            return mst;
        }

        public List<Edge> Kruskal(){
            List<Edge> mst = new List<Edge>();

            edges.Sort();

            NodesSet nodeSet = new NodesSet(nodes);

            foreach (Edge edge in edges){
                Node root1 = nodeSet.Find(edge.getN1());
                Node root2 = nodeSet.Find(edge.getN2());

                if (root1 != root2){
                    mst.Add(edge);
                    nodeSet.Union(root1, root2);
                }
            }

            return mst;
        }
    }
}