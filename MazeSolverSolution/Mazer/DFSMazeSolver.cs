namespace Mazer;

public class DFSMazeSolver : IMazeSolver
{
    public bool TrySolve(IMaze toSolve, out List<Position> solution)
    {
        HashSet<Position> visited = new ();
        Position currentPosition = toSolve.Start;
        solution = new List<Position>() { currentPosition };
        visited.Add(currentPosition);

        while (currentPosition != toSolve.End)
        {
            IEnumerable<Position> neighbors = 
                MazeUtils.GetValidNeighbors(currentPosition, toSolve, visited);
            
            // No possible moves from this position, backtrack
            if (!neighbors.Any())
            {
                solution.RemoveAt(solution.Count - 1);
                if (solution.Count == 0)
                {
                    return false;
                }
                currentPosition = solution[solution.Count - 1];
                continue;
            }

            Position nextPosition = neighbors.First();
            solution.Add(nextPosition);
            currentPosition = nextPosition;
            visited.Add(currentPosition);
        }

        return true;
    }
}
