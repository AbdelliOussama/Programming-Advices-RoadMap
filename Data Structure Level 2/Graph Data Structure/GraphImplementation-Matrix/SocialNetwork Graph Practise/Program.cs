using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork_Graph_Practice
{
    public class SocialMediaUser
    {
        public string UserName { get; set; }
        public int UserID { get; set; }

        public SocialMediaUser(string userName, int userID)
        {
            UserName = userName;
            UserID = userID;
        }

        public override string ToString()
        {
            return $"UserID: {UserID}, UserName: {UserName}";
        }
    }

    public class Graph
    {
        public enum RelationshipType { Single = 0, Double = 1 }

        private int[,] _AdjacencyMatrix;
        private Dictionary<SocialMediaUser, int> _VertexDictionary;
        private int _NumberOfVertices;
        private RelationshipType _GraphDirectionType;

        public Graph(List<SocialMediaUser> vertices, RelationshipType graphDirectionType)
        {
            _NumberOfVertices = vertices.Count;
            _VertexDictionary = new Dictionary<SocialMediaUser, int>();
            _AdjacencyMatrix = new int[_NumberOfVertices, _NumberOfVertices];
            _GraphDirectionType = graphDirectionType;

            for (int i = 0; i < _NumberOfVertices; i++)
            {
                _VertexDictionary[vertices[i]] = i;
            }
        }

        public void AddFriendship(SocialMediaUser user1, SocialMediaUser user2, int weight)
        {
            if (_VertexDictionary.ContainsKey(user1) && _VertexDictionary.ContainsKey(user2))
            {
                int user1Index = _VertexDictionary[user1];
                int user2Index = _VertexDictionary[user2];

                _AdjacencyMatrix[user1Index, user2Index] = weight;

                if (_GraphDirectionType == RelationshipType.Double)
                {
                    _AdjacencyMatrix[user2Index, user1Index] = weight;
                }
            }
            else
            {
                Console.WriteLine($"Ignored, invalid users: {user1} ==> {user2}");
            }
        }

        public void RemoveFriendship(SocialMediaUser user1, SocialMediaUser user2)
        {
            if (_VertexDictionary.ContainsKey(user1) && _VertexDictionary.ContainsKey(user2))
            {
                int user1Index = _VertexDictionary[user1];
                int user2Index = _VertexDictionary[user2];

                _AdjacencyMatrix[user1Index, user2Index] = 0;

                if (_GraphDirectionType == RelationshipType.Double)
                {
                    _AdjacencyMatrix[user2Index, user1Index] = 0;
                }
            }
            else
            {
                Console.WriteLine($"Ignored, invalid users: {user1} ==> {user2}");
            }
        }

        public void DisplayGraph()
        {
            Console.Write("    "); // Indentation for vertex labels
            foreach (var vertex in _VertexDictionary.Keys)
            {
                Console.Write($"{vertex.UserName,-10}");
            }
            Console.WriteLine();

            foreach (var source in _VertexDictionary)
            {
                Console.Write($"{source.Key.UserName,-10}");
                for (int j = 0; j < _NumberOfVertices; j++)
                {
                    Console.Write($"{_AdjacencyMatrix[source.Value, j],-10}");
                }
                Console.WriteLine();
            }
        }

        public bool IsFriend(SocialMediaUser user1, SocialMediaUser user2)
        {
            if (_VertexDictionary.ContainsKey(user1) && _VertexDictionary.ContainsKey(user2))
            {
                int user1Index = _VertexDictionary[user1];
                int user2Index = _VertexDictionary[user2];

                return _AdjacencyMatrix[user1Index, user2Index] > 0;
            }
            return false;
        }

        public int GetNumberOfFollowers(SocialMediaUser user)
        {
            int numberOfFollowers = 0;
            if (_VertexDictionary.ContainsKey(user))
            {
                int userIndex = _VertexDictionary[user];

                for (int i = 0; i < _NumberOfVertices; i++)
                {
                    if (_AdjacencyMatrix[userIndex, i] > 0)
                        numberOfFollowers++;
                }
            }
            return numberOfFollowers;
        }

        public int GetNumberOfFollowed(SocialMediaUser user)
        {
            int numberOfFollowed = 0;
            if (_VertexDictionary.ContainsKey(user))
            {
                int userIndex = _VertexDictionary[user];

                for (int i = 0; i < _NumberOfVertices; i++)
                {
                    if (_AdjacencyMatrix[i, userIndex] > 0)
                        numberOfFollowed++;
                }
            }
            return numberOfFollowed;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> userIDs = new HashSet<int>();
            List<SocialMediaUser> users = new List<SocialMediaUser>
            {
                new SocialMediaUser("Oussama", 1),
                new SocialMediaUser("Rami", 2),
                new SocialMediaUser("Ghassen", 3),
                new SocialMediaUser("Safa", 4),
                new SocialMediaUser("Ghalia", 5),
                new SocialMediaUser("Salim", 6),
                new SocialMediaUser("Majdi", 7),
                new SocialMediaUser("Ahmed", 8)
            };

            // Ensure unique users
            users = new List<SocialMediaUser>(users.Where(user => userIDs.Add(user.UserID)));

            Graph usersGraph = new Graph(users, Graph.RelationshipType.Double);

            usersGraph.AddFriendship(users[0], users[1], 1);
            usersGraph.AddFriendship(users[1], users[2], 1);
            usersGraph.AddFriendship(users[0], users[3], 1);

            Console.WriteLine("Displaying Graph:");
            usersGraph.DisplayGraph();

            Console.WriteLine($"\nIs {users[0].UserName} friends with {users[1].UserName}? {usersGraph.IsFriend(users[0], users[1])}");
            Console.WriteLine($"Number of followers of {users[0].UserName}: {usersGraph.GetNumberOfFollowers(users[0])}");
            Console.WriteLine($"Number of followed by {users[0].UserName}: {usersGraph.GetNumberOfFollowed(users[0])}");
        }
    }
}
