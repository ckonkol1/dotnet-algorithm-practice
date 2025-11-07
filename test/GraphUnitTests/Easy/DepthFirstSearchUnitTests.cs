using Graph.Models;

namespace GraphUnitTests.Easy
{
    public class DepthFirstSearchUnitTests
    {
        [Fact]
        public void TestDepthFirstSearch()
        {
            var graph = new Node("A");
            graph.AddChild("B").AddChild("C").AddChild("D");
            graph.Children[0].AddChild("E").AddChild("F");
            graph.Children[2].AddChild("G").AddChild("H");
            graph.Children[0].Children[1].AddChild("I").AddChild("J");
            graph.Children[2].Children[0].AddChild("K");
            var expectedResult = new List<string>() { "A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H" };

            var result = new List<string>();
            graph.DepthFirstSearch(result);
            Assert.Equivalent(expectedResult, result);
        }
    }
}