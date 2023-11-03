using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataSturcture.BasicTree
{
    public class TesterClass
    {

        static void Main(string[] args)
        {
            //#region name    
            //Node root = new Node(100);
            //Tree myTree = new Tree(root);
            //Node child1 = new Node(50);
            //Node child2 = new Node(1);
            //Node child3 = new Node(150);
            //Node child4 = new Node(70);
            //Node child5 = new Node(61);

            //child1.Parent = root;
            //child2.Parent = root;
            //child3.Parent = root;

            //child4.Parent = child2;
            //child5.Parent = child2;


            //root.Children.Add(child1);
            //root.Children.Add(child2);
            //root.Children.Add(child3);

            //child2.Children.Add(child4);
            //child2.Children.Add(child5);

            //foreach (Node x in root.Children)
            //{
            //    Console.WriteLine(x);
            //    foreach (Node y in x.Children)
            //    {
            //        Console.WriteLine("     "+y);
            //    }
            //}
            //#endregion 

            Tree tr = new Tree()
                .StartBranch(5)
                .CloseBranch()
                    .StartBranch(1)
                        .Add(6)
                        .Add(3)
                        .Add(7)
                    .CloseBranch()
                    .StartBranch(2)
                        .StartBranch(3)
                            .Add(7)
                        .CloseBranch()
                    .CloseBranch();
                
        


        //tr.Root.addNode(5);
        //tr.Root.addNode(8);


        //tr.Root.Children[0].addNode(2);
        //tr.Root.Children[0].addNode(3);
        //tr.Root.Children[0].addNode(1);


        //tr.Root.Children[0].Children[0].addNode(13);
        //tr.Root.Children[0].Children[0].addNode(6);


        //tr.Root.Children[1].addNode(10);
        //tr.Root.Children[1].addNode(12);


            //genTree(tr.Root,0);
            foreach (Node x in tr.Nodes)
            {
                Console.WriteLine(x);
                foreach (Node y in x.Children)
                {
                    Console.WriteLine("     " + y);
                    foreach (Node z in y.Children)
                    {
                        Console.WriteLine("             " + z);
                        foreach (Node i in z.Children)
                        {
                            Console.WriteLine("                 " + i);
                        }
                    }
                }
            }


            Console.ReadKey();

        }

        public static void genTree(Node tr, int level)
        {
            
            foreach (Node x in tr.Children)
            {
                Console.WriteLine(new string('\t', level) + x);
                ;
                if (x.Children.Count > 0)
                {
                    genTree(x,level+1);
                }
            }


        }
    }
}
