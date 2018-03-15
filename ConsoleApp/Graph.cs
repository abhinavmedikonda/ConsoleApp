using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Graph
    {
        public char Character;

        public List<Graph> Next;
    }

    

    public class GraphOperations
    {
        static Dictionary<char, Graph> dictionary = new Dictionary<char, Graph>();

        public void TraverseGraph(Graph theGraph)
        {
            foreach(Graph graph in theGraph.Next)
            {
                if (!dictionary.ContainsValue( theGraph ))
                {
                    dictionary.Add( graph.Character, graph );
                    GraphOperations graphOperations = new GraphOperations();
                    graphOperations.TraverseGraph(graph);
                }
            }
        }
    }
}
