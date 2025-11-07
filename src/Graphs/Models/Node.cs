namespace Graph.Models;

public class Node
{
    public string Name;
    public List<Node> Children = new List<Node>();

    public Node(string name)
    {
        this.Name = name;
    }

    public Node AddChild(string name)
    {
        Node child = new Node(name);
        Children.Add(child);
        return this;
    }

    /*
     * Depth-first Search
        You're given a Node class that has a name and an array of optional children nodes. When put together. nodes form an acyclic tree-like structure.
        Implement the depthFirstsearch method on the Node class, which takes in an empty array, traverses the tree using the Depth-first
        Search approach (specifically navigating the tree from left to right), stores all of the nodes' names in the input array, and returns it.

        Sample Input:  graph =   A
                              /  |  \
                             B   C   D
                           /  \    /   \
                          E    F  G     H
                             /  \   \
                            I    J   K

        Sample Output: ["A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H"]

       Optimal Space & Time Complexity
       O(v + e) time I O(v) space - where v is the number of vertices of the input graph and e is the number of edges of the input graph
     */
    public List<string> DepthFirstSearch(List<string> array)
    {
        array.Add(this.Name);
        foreach (var child in this.Children)
        {
            child.DepthFirstSearch(array);
        }

        return array;
    }

    /*
     * Breadth-first Search
        You're given a Node class that has a name and an array of optional children nodes. When put together, nodes form an acyclic tree-like structure.
        Implement the breadthFirstSearch method on the Node class, which takes in an empty array, traverses the tree using the Breadth-first Search approach (specifically navigating the tree from left to right), stores all of the nodes' names in the input array, and returns it.
        Sample Input:  graph =   A
                              /  |  \
                             B   C   D
                           /  \    /   \
                          E    F  G     H
                             /  \   \
                            I    J   K
        Sample Output: ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K"]
       Optimal Space & Time Complexity
       O(v + e) time I O(v) space - where v is the number of vertices of the input graph and e is the number of edges of the input graph
     *
     */
    public List<string> BreadthFirstSearch(List<string> array)
    {
        var queue = new Queue<Node>();
        var visited = new Dictionary<string, bool>();
        queue.Enqueue(this);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (visited.TryAdd(node.Name, true))
            {
                array.Add(node.Name);
                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        return array;
    }
}