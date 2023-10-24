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

         // cGraph.addEdges(1, 3);
            cGraph.addEdges(2, 3);

            bool yes = cGraph.hasPathDFS(1, 3);

                if(yes)
            {

                Console.WriteLine("Nicole is related to Stefan, they can be cousins.");
            }

                else
            {
                Console.WriteLine("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO :)");
            }

            bool BFSYes = cGraph.hasPathDFS(2, 3);

            if(BFSYes)
            {
                Console.WriteLine("BFS PATH FOUND between Luke and Stefan");
            }

            else
            {
                Console.WriteLine( "NOOOOOO");
            }    






        }
    }
}