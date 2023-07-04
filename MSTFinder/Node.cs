using System.Collections.Generic;

namespace MSTFinder{
    class Node{
        private int n;
        private List<int> neighbor;

        public Node(int n){
            this.n = n;
            this.neighbor = new List<int>();
        }

        public int getN(){
            return this.n;
        }

        public void setN(int n){
            this.n = n;
        }

        public List<int> getNeighbor(){
            return this.neighbor;
        }

        public void setNeighbor(List<int> neighbor){
            this.neighbor = neighbor;
        }

        public void addNeighbor(int node){
            this.neighbor.Add(node);
        }

        public bool isNeighbor(int node){
            return this.neighbor.Contains(node);
        }

        public void deleteNeighbor(int node){
            this.neighbor.Remove(node);
        }
    }
}