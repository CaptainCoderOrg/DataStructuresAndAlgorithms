// public class Position
public class Position
{
    public Position(int x, int y) => (X, Y) = (x, y);
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override string ToString()
    {
        return $"Position (X: {X}, Y: {Y})";
    }
}