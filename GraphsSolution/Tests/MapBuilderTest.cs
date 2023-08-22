namespace Tests;
using CaptainCoder.Graph;
using Shouldly;

public class MapBuilderTest
{
    // Hoboken, NJ
    // The Musium
    // Boss Room
    // Death Platform
    [Fact]
    public void test_add_location()
    {
        // Triple A testing (AAA)
        // Arrange
        MapBuilder builder = new MapBuilder();

        // Act
        builder.AddLocation("Captain Coder's Academy");
        IGameMap map = builder.Build();

        // Assert
        map.Locations.Count().ShouldBe(1);
        map.Locations.ShouldContain("Captain Coder's Academy");
    }

    // [Fact]
    // public void test_add_locations()
    // {

    // }
}