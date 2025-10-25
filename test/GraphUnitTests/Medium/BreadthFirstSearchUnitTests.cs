using Graph.Models;

namespace GraphUnitTests.Medium;

public class BreadthFirstSearchUnitTests
{
    [Fact]
    public void BreadthFirstSearch_SampleTree_ReturnsCorrectOrder()
    {
        // Build the sample tree:
        //        A
        //     /  |  \
        //    B   C   D
        //  /  \    /   \
        // E    F  G     H
        //    /  \   \
        //   I    J   K
        var graph = new Node("A");
        graph.AddChild("B").AddChild("C").AddChild("D");
        graph.Children[0].AddChild("E").AddChild("F");
        graph.Children[2].AddChild("G").AddChild("H");
        graph.Children[0].Children[1].AddChild("I").AddChild("J");
        graph.Children[2].Children[0].AddChild("K");

        var result = graph.BreadthFirstSearch(new List<string>());
        var expected = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BreadthFirstSearch_SingleNode_ReturnsSingleName()
    {
        var node = new Node("X");
        var result = node.BreadthFirstSearch(new List<string>());
        Assert.Equal(new List<string> { "X" }, result);
    }

    [Fact]
    public void BreadthFirstSearch_LinearTree_ReturnsCorrectOrder()
    {
        // A -> B -> C -> D
        var node = new Node("A");
        node.AddChild("B");
        node.Children[0].AddChild("C");
        node.Children[0].Children[0].AddChild("D");

        var result = node.BreadthFirstSearch(new List<string>());
        var expected = new List<string> { "A", "B", "C", "D" };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BreadthFirstSearch_TwoLevelTree_ReturnsCorrectOrder()
    {
        //   A
        //  / \
        // B   C
        var node = new Node("A");
        node.AddChild("B").AddChild("C");

        var result = node.BreadthFirstSearch(new List<string>());
        var expected = new List<string> { "A", "B", "C" };
        Assert.Equal(expected, result);
    }
}