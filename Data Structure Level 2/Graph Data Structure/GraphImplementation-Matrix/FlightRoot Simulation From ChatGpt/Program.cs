using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FlightRoot_Simulation_From_ChatGpt
{
    public class Airport
    {
        string Code { get; set; }
        string Name { get; set; }

        public Airport(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
        public override string ToString()
        {
            return this.Code;
        }
    }
    public class Graph<T>
    {
        public enum enGraphDirectionType { Directed = 0,Undirected =1};
        private int[,] _AdjacencyMatrix;
        private int _NumberOfVertecies;
        private Dictionary<T,int> _VerteciesDictionary;
        private enGraphDirectionType _DirectionType;

        public Graph(List<T>Vertecies,enGraphDirectionType DirectionType)
        {
            _NumberOfVertecies = Vertecies.Count;
            _AdjacencyMatrix = new int[_NumberOfVertecies,_NumberOfVertecies];
            _DirectionType = DirectionType;
            _VerteciesDictionary = new Dictionary<T,int>();

            for (int i = 0; i < _NumberOfVertecies; i++)
            {
                _VerteciesDictionary[Vertecies[i]] = i;
            }  
        }
        public void AddEdge(T Vertex1,T Vertex2 ,int Wheight)
        {
            if(_VerteciesDictionary.ContainsKey(Vertex1) && _VerteciesDictionary.ContainsKey(Vertex2))
            {
                int Vertex1Index = _VerteciesDictionary[Vertex1];
                int Vertex2Index = _VerteciesDictionary[Vertex2];

                _AdjacencyMatrix[Vertex1Index,Vertex2Index] = Wheight;

                if(_DirectionType ==enGraphDirectionType.Undirected)
                {
                    _AdjacencyMatrix[Vertex2Index,Vertex1Index] = Wheight;
                }
            }
            else
            {
                Console.WriteLine($"Invalid Connection {Vertex1} ==> {Vertex2}");
            }
        }
        public void RemoveEdge(T Vertex1,T Vertex2)
        {
            if (_VerteciesDictionary.ContainsKey(Vertex1) && _VerteciesDictionary.ContainsKey(Vertex2))
            {
                int Vertex1Index = _VerteciesDictionary[Vertex1];
                int Vertex2Index = _VerteciesDictionary[Vertex2];

                _AdjacencyMatrix[Vertex1Index, Vertex2Index] =0 ;
                if (_DirectionType == enGraphDirectionType.Undirected)
                {
                    _AdjacencyMatrix[Vertex2Index, Vertex1Index] =0;
                }
            }
            else
            {
                Console.WriteLine($"Invalid Connection {Vertex1} ==> {Vertex2}");
            }
        }
        public bool IsEdge(T Vertex1,T Vertex2)
        {
            if (_VerteciesDictionary.ContainsKey(Vertex1) && _VerteciesDictionary.ContainsKey(Vertex2))
            {
                int Vertex1Index = _VerteciesDictionary[Vertex1];
                int Vertex2Index = _VerteciesDictionary[Vertex2];

                return _AdjacencyMatrix[Vertex1Index,Vertex2Index]>0 ;
            }
            return false;
        }

        public void DispalyGraph()
        {
            Console.WriteLine("Adjacency Matrix:");

            // Print the column headers
            Console.Write("       ");
            foreach (var vertex in _VerteciesDictionary.Keys)
            {
                Console.Write($"{vertex,-8}");
            }
            Console.WriteLine();

            // Print a separator line
            Console.WriteLine(new string('-', 8 + _NumberOfVertecies * 8));

            // Print each row with its row label
            foreach (var source in _VerteciesDictionary)
            {
                Console.Write($"{source.Key,-8}"); // Row label
                for (int i = 0; i < _NumberOfVertecies; i++)
                {
                    Console.Write($"{_AdjacencyMatrix[source.Value, i],-8}"); // Adjacency matrix value
                }
                Console.WriteLine();
            }
        }



        public int NumberOfInEdges(T Vertex1)
        {
            int NumberOfInEdges = 0 ;
            if( _VerteciesDictionary.ContainsKey(Vertex1))
            {
                int VertexIndex = _VerteciesDictionary[Vertex1];
                for(int i=0;i<_NumberOfVertecies;i++)
                {
                    if (_AdjacencyMatrix[i,VertexIndex]>0 ) 
                        NumberOfInEdges++;
                }

            }
            return NumberOfInEdges;
        }
        public int NumberOfOutEdges(T Vertex1)
        {
            int NumberOfOutEdges = 0;
            if (_VerteciesDictionary.ContainsKey(Vertex1))
            {
                int VertexIndex = _VerteciesDictionary[Vertex1];
                for (int i = 0; i < _NumberOfVertecies; i++)
                {
                    if (_AdjacencyMatrix[VertexIndex,i] > 0)
                        NumberOfOutEdges++;
                }

            }
            return NumberOfOutEdges;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Airport> airports = new List<Airport>()
            {
                new Airport("JFK", "John F. Kennedy International Airport"),
                new Airport("LAX", "Los Angeles International Airport"),
                new Airport("ORD", "O'Hare International Airport"),
                new Airport("ATL", "Hartsfield-Jackson Atlanta International Airport")
            };

            Graph<Airport> AirportRouts = new Graph<Airport>(airports, Graph<Airport>.enGraphDirectionType.Undirected);

            // Add routes
            AirportRouts.AddEdge(airports[0], airports[1], 3000);
            AirportRouts.AddEdge(airports[0], airports[2], 1200);
            AirportRouts.AddEdge(airports[2], airports[3], 1000);
            AirportRouts.AddEdge(airports[1], airports[3], 3500);

            Console.WriteLine("All Routes:");
            AirportRouts.DispalyGraph();

            // Remove a route
            Console.WriteLine("\nFlight Routes After Updating:");
            AirportRouts.RemoveEdge(airports[2], airports[3]);
            AirportRouts.DispalyGraph();

            // Check connectivity
            Console.WriteLine($"\nIs there a direct flight between LAX and ORD? {(AirportRouts.IsEdge(airports[1], airports[2]) ? "Yes" : "No")}");

            // Count flights
            Console.WriteLine($"\nThe number of flights coming to and going from JFK: " +
                              $"{AirportRouts.NumberOfInEdges(airports[0]) + AirportRouts.NumberOfOutEdges(airports[0])}");
        }

    }
}
