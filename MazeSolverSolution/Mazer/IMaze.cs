namespace Mazer;

public interface IMaze
{
    public int Rows { get; }
    public int Columns { get; }
    public Position Start { get; }
    public Position End { get; }
    public bool IsPassable(Position position);
}
