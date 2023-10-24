using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataSturcture.BasicTree
{
    public class TesterClass
    {

        static void Main(string[] args)
        {
            Node root = new Node(100);
            Tree myTree = new Tree(root);
            Node child1 = new Node(50);
            Node child2 = new Node(1);
            Node child3 = new Node(150);
            Node child4 = new Node(70);
            Node child5 = new Node(61);

            child1.Parent = root;
            child2.Parent = root;
            child3.Parent = root;

            child4.Parent = child2;
            child5.Parent = child2;


            root.Children.Add(child1);
            root.Children.Add(child2);
            root.Children.Add(child3);

            child2.Children.Add(child4);
            child2.Children.Add(child5);

            foreach (Node x in root.Children)
            {
                Console.WriteLine(x);
                foreach (Node y in x.Children)
                {
                    Console.WriteLine("     "+y);
                }
            }

            

            Console.ReadKey();

        }
    }
}
