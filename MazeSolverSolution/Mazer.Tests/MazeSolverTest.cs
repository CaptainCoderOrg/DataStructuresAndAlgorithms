using Shouldly;
namespace Mazer.Tests;

public class MazeSolverTest
{
    [Fact]
    public void test_simple_east_maze()
    {
        // Triple A Testing (AAA)
        // Arrange
        IMaze simple = MazeBuilder.FromString(
            """
            #####
            #S E#
            #####
            """
        );
        IMazeSolver mazeSolver = IMazeSolver.Default;

        // Act
        bool result = mazeSolver.TrySolve(simple, out List<Position> solution);

        // Assert
        result.ShouldBeTrue();
        solution.Count.ShouldBe(3);
        solution[0].ShouldBe(new Position(0, 0));
        solution[1].ShouldBe(new Position(0, 1));
        solution[2].ShouldBe(new Position(0, 2));
    }

    [Fact]
    public void test_simple_south_maze()
    {
        // Triple A Testing (AAA)
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
        IMazeSolver mazeSolver = IMazeSolver.Default;

        // Act
        bool result = mazeSolver.TrySolve(simple, out List<Position> solution);

        // Assert
        result.ShouldBeTrue();
        solution.Count.ShouldBe(3);
        solution[0].ShouldBe(new Position(0, 0));
        solution[1].ShouldBe(new Position(1, 0));
        solution[2].ShouldBe(new Position(2, 0));
    }

    [Fact]
    public void test_solve_maze()
    {
        // Triple A Testing (AAA)
        // Arrange
        IMaze simple = MazeBuilder.FromString(
            """
            #########
            #S      #
            ## #### #
            ## ######
            #      E#
            #########
            """
        );
            //         """
            // #########
            // #S......#
            // ##.####.#
            // ##.######
            // # .....E#
            // #########
            // """
        IMazeSolver mazeSolver = IMazeSolver.Default;

        // Act
        bool result = mazeSolver.TrySolve(simple, out List<Position> solution);

        // Assert
        result.ShouldBeTrue();
        solution.Count.ShouldBe(10);
        solution[0].ShouldBe(new Position(0, 0));
        solution[1].ShouldBe(new Position(0, 1));
        solution[2].ShouldBe(new Position(1, 1));
        solution[3].ShouldBe(new Position(2, 1));
        solution[4].ShouldBe(new Position(3, 1));
        solution[5].ShouldBe(new Position(3, 2));
        solution[6].ShouldBe(new Position(3, 3));
        solution[7].ShouldBe(new Position(3, 4));
        solution[8].ShouldBe(new Position(3, 5));
        solution[9].ShouldBe(new Position(3, 6));
    }
}