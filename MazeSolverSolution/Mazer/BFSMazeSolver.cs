namespace Mazer;

public class BFSMazeSolver : IMazeSolver
{
    public bool TrySolve(IMaze toSolve, out List<Position> solution)
    {
        HashSet<Position> visited = new ();
        Position currentPosition = toSolve.Start;
        solution = new List<Position>() { };
        visited.Add(currentPosition);

        return true;
    }
}
