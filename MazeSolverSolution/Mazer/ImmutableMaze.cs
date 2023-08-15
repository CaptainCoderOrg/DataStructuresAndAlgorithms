namespace Mazer;

internal class ImmutableMaze : IMaze
{
    private HashSet<Position> _positions;
    internal ImmutableMaze(Position start, Position end, IEnumerable<Position> positions)
    {
        (Position topLeft, Position bottomRight) = FindCorners(positions);
        _positions = positions.Select(p => new Position(p.Row - topLeft.Row, p.Column - topLeft.Column)).ToHashSet();
        Start = new Position(start.Row - topLeft.Row, start.Column - topLeft.Column);
        End = new Position(end.Row - topLeft.Row, end.Column - topLeft.Column);
        Rows = bottomRight.Row - topLeft.Row + 1;
        Columns = bottomRight.Column - topLeft.Column + 1;
    }

    private (Position, Position) FindCorners(IEnumerable<Position> walls)
    {
        int minRow = int.MaxValue;
        int maxRow = int.MinValue;
        int minCol = int.MaxValue;
        int maxCol = int.MinValue;
        foreach (var position in walls)
        {
            minRow = Math.Min(minRow, position.Row);
            maxRow = Math.Max(maxRow, position.Row);
            minCol = Math.Min(minCol, position.Column);
            maxCol = Math.Max(maxCol, position.Column);
        }
        return (new Position(minRow, minCol), new Position(maxRow, maxCol));
    }

    public int Rows { get; }
    public int Columns { get; }
    public Position Start { get; }
    public Position End { get; }

    public bool IsPassable(Position position) => _positions.Contains(position);
}
