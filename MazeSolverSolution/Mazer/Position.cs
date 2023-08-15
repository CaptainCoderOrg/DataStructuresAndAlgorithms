namespace Mazer;

public record struct Position(int Row, int Column)
{
    public Position North() => this with { Row = Row - 1 };
    public Position South() => this with { Row = Row + 1 };
    public Position East() => this with { Column = Column + 1 };
    public Position West() => this with { Column = Column - 1 };
}