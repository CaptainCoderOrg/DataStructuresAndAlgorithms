using Shouldly;
namespace Mazer.Tests;

public class MazeUtilsTest
{

    [Fact]
    public void test_get_valid_neighbors_south()
    {
        // Triple A testing (AAA): Arrange, Act, Assert

        // Arrange
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
        neighbors.Count().ShouldBe(1);
        neighbors.ShouldContain(new Position(1, 0));
    }

    [Fact]
    public void test_get_valid_neighbors_all_dirs()
    {
        // Triple A testing (AAA): Arrange, Act, Assert

        // Arrange
        IMaze simple = MazeBuilder.FromString(
            """
             ### 
            ## ##
            # S #
             # #
             #E#
             ###
            """
        );

        // Act
        IEnumerable<Position> neighbors = MazeUtils.GetValidNeighbors(new Position(2, 2), simple, new HashSet<Position>());

        // Assert
        neighbors.Count().ShouldBe(4);
        neighbors.ShouldContain(new Position(2, 3));
        neighbors.ShouldContain(new Position(2, 1));
        neighbors.ShouldContain(new Position(1, 2));
        neighbors.ShouldContain(new Position(3, 2));
    }

    [Fact]
    public void test_get_valid_neighbors_all_dirs_some_visited()
    {
        // Triple A testing (AAA): Arrange, Act, Assert

        // Arrange
        IMaze simple = MazeBuilder.FromString(
            """
             ### 
            ## ##
            # S #
             # #
             #E#
             ###
            """
        );

        // Act
        HashSet<Position> visited = new () { new Position(2, 3), new Position(3, 2)};
        IEnumerable<Position> neighbors = MazeUtils.GetValidNeighbors(new Position(2, 2), simple, visited);

        // Assert
        neighbors.Count().ShouldBe(2);
        neighbors.ShouldContain(new Position(2, 1));
        neighbors.ShouldContain(new Position(1, 2));
    }

}
