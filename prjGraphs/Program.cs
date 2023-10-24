namespace prjGraphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
          CGraph cGraph = new CGraph();
            cGraph.addNode(1, "Nicole");
            cGraph.addNode(2, "Luke");
            cGraph.addNode(3, "Stefan");
            cGraph.addNode(4, "Batman");
            cGraph.addNode(5, "Spider-Man");
            cGraph.addNode(6, "Capitilism");
            cGraph.addNode(7, "Reeeeeeeeeeece");
            cGraph.addNode(8, "bruh");
            cGraph.addNode(9, "Rooooar");
          

         // cGraph.addEdges(1, 3);
            cGraph.addEdges(2, 3);
            cGraph.addEdges(3, 4);
            cGraph.addEdges(4, 3);
            cGraph.addEdges(7, 6);
            cGraph.addEdges(3, 6);
            cGraph.addEdges(1, 7);
            cGraph.addEdges(2, 5);
            cGraph.addEdges(7, 9);
            cGraph.addEdges(1, 5);

            bool yes = cGraph.hasPathDFS(1, 3);

                if(yes)
            {

                Console.WriteLine("Nicole is related to Stefan, they can be cousins.");
            }

                else
            {
                Console.WriteLine("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO :)");
            }

            bool BFSYes = cGraph.hasPathBFS(1, 5);

            if(BFSYes)
            {
                Console.WriteLine("BFS PATH FOUND between Luke and Stefan");
            }

            else
            {
                Console.WriteLine( "NOOOOOO");
            }

             yes = cGraph.hasPathDFS(1, 5);


            if(yes)
            {
                Console.WriteLine("REEEEE");
            }





        }
    }
}