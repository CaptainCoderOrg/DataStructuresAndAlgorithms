namespace Mazer;

public static class MazePrinter
{
    public static void PrintMaze(IMaze toPrint)
    {
        for (int row = -1; row <= toPrint.Rows; row++)
        {
            for (int col = -1; col <= toPrint.Columns; col++)
            {
                Console.Write(Symbol(new Position(row, col), toPrint));
            }
            Console.WriteLine();
        }
    }

    private static char Symbol(Position position, IMaze maze)
    {
        if (position == maze.Start)
        {
            return 'S';
        }

        if (position == maze.End)
        {
            return 'E';
        }

        if(!maze.IsPassable(position))
        {
            return '#';
        }

        return ' ';
    }

}
