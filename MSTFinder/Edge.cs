namespace MSTFinder{
    class Edge: System.IComparable<Edge>
    {
        private Node n1;
        private Node n2;
        private double weight;

        public Edge(Node n1, Node n2, double weight){
            this.n1 = n1;
            this.n2 = n2;
            this.weight = weight;
        }

        public Node getN1(){
            return this.n1;
        }

        public void setN1(Node n1){
            this.n1 = n1;
        }

        public Node getN2(){
            return this.n2;
        }

        public void setN2(Node n2){
            this.n2 = n2;
        }

        public double getWeight(){
            return this.weight;
        }

        public void setWeight(double weight){
            this.weight = weight;
        }

        public int CompareTo(Edge other){
            return weight.CompareTo(other.weight);
        }
    }
}