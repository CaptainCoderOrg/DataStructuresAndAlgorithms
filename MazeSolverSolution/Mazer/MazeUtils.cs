namespace Mazer;

public static class MazeUtils
{
    public static IEnumerable<Position> GetValidNeighbors(Position currentPosition, IMaze toSolve, HashSet<Position> visited)
    {
        IEnumerable<Position> neighbors = new Position[]{ 
                currentPosition.North(), 
                currentPosition.South(), 
                currentPosition.East(), 
                currentPosition.West() 
        }.Where(pos => toSolve.IsPassable(pos) && !visited.Contains(pos));
        return neighbors;
    }

    internal static void Print(this IEnumerable<Position> positions)
    {
        Console.WriteLine(string.Join(", ", positions.Select(p => $"({p.Row}, {p.Column})")));
    }
}
