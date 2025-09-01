using Graph.Models;

namespace GraphUnitTests
{
    public class GraphUnitTests
    {
        [Fact]
        public void TestDepthFirstSearch()
        {
            var graph = new Node("A");
            graph.AddChild("B").AddChild("C").AddChild("D");
            graph.children[0].AddChild("E").AddChild("F");
            graph.children[2].AddChild("G").AddChild("H");
            graph.children[0].children[1].AddChild("I").AddChild("J");
            graph.children[2].children[0].AddChild("K");
            var expectedResult = new List<string>() { "A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H" };

            var result = new List<string>();
            graph.DepthFirstSearch(result);
            Assert.Equivalent(expectedResult, result);
        }
    }
}