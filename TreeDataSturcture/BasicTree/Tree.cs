using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataSturcture.BasicTree
{
    public class Tree
    {
        public Node Root { get; set; }
        public List<Node> Nodes { get; set; }

        private Stack<Node> _st = new Stack<Node>();
        

        public Tree(Node root)
        {
            Root = root;
        }

        public Tree StartBranch(int Data)
        {
            if (_st.Count == 0)
            {
                Node newNode = new Node(Data,null);
                Nodes.Add(newNode);
                _st.Push(newNode);
            }
            else
            {
                Node parentNode = _st.Peek().addNode(Data);
                _st.Push(parentNode);
            }

            return this;
        }

        public Tree Add(int Data)
        {
            this._st.Peek().addNode(Data);
            return this;
        }

        public  Tree CloseBranch()
        {
            this._st.Pop();
            return this;
        }

    }
}
