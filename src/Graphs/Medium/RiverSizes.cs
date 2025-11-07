namespace Graph.Medium;

public static class RiverSizes
{
    public static List<int> GetRiverSizes(int[,] matrix)
    {
        var riverSizes = new List<int>();
        var visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (visited[i, j])
                {
                    continue;
                }

                TraverseNode(i, j, matrix, visited, riverSizes);
            }
        }

        return riverSizes;
    }

    private static void TraverseNode(int i, int j, int[,] matrix, bool[,] visited, List<int> riverSizes)
    {
        var currentRiverSize = 0;
        var nodesToExplore = new Stack<int[]>();
        nodesToExplore.Push([i, j]);

        while (nodesToExplore.Count != 0)
        {
            var currentNode = nodesToExplore.Pop();
            i = currentNode[0];
            j = currentNode[1];
            if (visited[i, j])
            {
                continue;
            }

            visited[i, j] = true;
            if (matrix[i, j] == 0)
            {
                continue;
            }

            currentRiverSize++;
            var unvisitedNeighbors = GetUnvisitedNeighbors(i, j, matrix, visited);
            foreach (var neighbor in unvisitedNeighbors)
            {
                nodesToExplore.Push(neighbor);
            }
        }

        if (currentRiverSize > 0)
        {
            riverSizes.Add(currentRiverSize);
        }
    }

    private static List<int[]> GetUnvisitedNeighbors(int i, int j, int[,] matrix, bool[,] visited)
    {
        var unvisitedNeighbor = new List<int[]>();
        if (i > 0 && !visited[i - 1, j])
        {
            unvisitedNeighbor.Add([i - 1, j]);
        }

        if (i < matrix.GetLength(0) - 1 && !visited[i + 1, j])
        {
            unvisitedNeighbor.Add([i + 1, j]);
        }

        if (j > 0 && !visited[i, j - 1])
        {
            unvisitedNeighbor.Add([i, j - 1]);
        }

        if (j < matrix.GetLength(1) - 1 && !visited[i, j + 1])
        {
            unvisitedNeighbor.Add([i, j + 1]);
        }

        return unvisitedNeighbor;
    }
}