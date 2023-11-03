using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataSturcture.BasicTree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Parent { get; set; }
        public List<Node> Children { get; set; }

        public Node(int data, Node parent)
        {
            Data = data;
            Children = new List<Node>();
            Parent = parent;
        }

        public Node addNode(int data)
        {
            Node newNode = new Node(data, this);
            this.Children.Add(newNode);
            return this;
        }
        public Node()
        {
            
        }

        public override string ToString()
        {
            return $"Data: ({Data}), Parent: ({Parent.Data})";
        }
    }

    
}
