namespace Mazer;

public class MazeBuilder
{
    private HashSet<Position> _positions = new HashSet<Position>();
    private Position _start;
    private Position _end;

    public MazeBuilder Start(Position position)
    {
        _start = position;
        return CarvePath(position);
    }

    public MazeBuilder End(Position position)
    {
        _end = position;
        return CarvePath(position);
    }

    public MazeBuilder CarvePath(Position position) 
    {
        _positions.Add(position);
        return this;
    }

    public IMaze Build() => new ImmutableMaze(_start, _end, _positions);

    public static IMaze FromString(string toParse)
    {
        string[] lines = toParse.Split("\n");
        MazeBuilder builder = new MazeBuilder();
        for (int row = 0; row < lines.Length; row++)
        {
            string line = lines[row];
            for (int col = 0; col < line.Length; col++)
            {
                char symbol = line[col];
                if (symbol == 'S')
                {
                    builder.Start(new Position(row, col));
                }
                else if (symbol == 'E')
                {
                    builder.End(new Position(row, col));
                }
                else if (symbol == ' ')
                {
                    builder.CarvePath(new Position(row, col));
                }
            }
        }
        return builder.Build();
    }
}
