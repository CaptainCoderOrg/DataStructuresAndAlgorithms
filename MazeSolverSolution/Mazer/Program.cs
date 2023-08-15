using Mazer;

// MazeBuilder builder = new MazeBuilder()
//     .Start(new Position(0, 0))
//     .CarvePath(new Position(0, 1))
//     .CarvePath(new Position(0, 2))
//     .CarvePath(new Position(0, 3))
//     .CarvePath(new Position(0, 4))
//     .CarvePath(new Position(1, 4))
//     .CarvePath(new Position(2, 4))
//     .CarvePath(new Position(3, 4))
//     .End(new Position(4, 4));

// IMaze maze = builder.Build();
IMaze maze = MazeBuilder.FromString(
    """
    #########
    #S      #
    ## #### #
    ## ######
    #      E#
    #########
    """
);

MazePrinter.PrintMaze(maze);