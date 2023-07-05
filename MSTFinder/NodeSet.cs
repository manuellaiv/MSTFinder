using System.Collections.Generic;

namespace MSTFinder{
    class NodesSet{
        private Dictionary<Node, Node> parent;

        public NodesSet(List<Node> elements){
            parent = new Dictionary<Node, Node>();
            foreach (Node element in elements){
                parent[element] = element;
            }
        }

        public Node Find(Node element){
            if (parent[element].Equals(element)){
                return element;
            }
            return Find(parent[element]);
        }

        public void Union(Node element1, Node element2){
            Node root1 = Find(element1);
            Node root2 = Find(element2);
            parent[root1] = root2;
        }
    }
}