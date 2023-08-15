using Mazer;

IMaze simple = MazeBuilder.FromString(
            """
            ###
            #S#
            # #
            #E#
            ###
            """
        );

// Act
IEnumerable<Position> neighbors = MazeUtils.GetValidNeighbors(new Position(0, 0), simple, new HashSet<Position>());

// Assert
// neighbors.Count().ShouldBe(1);
// neighbors.ShouldContain(new Position(1, 0));