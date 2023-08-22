namespace Tests;
using CaptainCoder.Graph;
using Shouldly;

public class MapBuilderTest
{
    // Hoboken, NJ
    // The Musium
    // Boss Room
    // Death Platform
    [Theory]
    [InlineData("Captain Coder's Academy")]
    [InlineData("Hoboken, NJ")]
    [InlineData("Boss Room")]
    [InlineData("Death Platform")]
    public void test_add_location(string location)
    {
        // Triple A testing (AAA)
        // Arrange
        MapBuilder builder = new MapBuilder();

        // Act
        builder.AddLocation(location);
        IGameMap map = builder.Build();

        // Assert
        map.Locations.Count().ShouldBe(1);
        map.Locations.ShouldContain(location);
    }

    [Theory]
    [InlineData("Captain Coder's Academy")]
    [InlineData("Hoboken, NJ")]
    [InlineData("Boss Room")]
    [InlineData("Death Platform")]
    public void test_add_duplicate_location(string location)
    {
        // Triple A testing (AAA)
        // Arrange
        MapBuilder builder = new MapBuilder();

        // Act
        builder.AddLocation(location);
        builder.AddLocation(location);
        builder.AddLocation(location);
        IGameMap map = builder.Build();

        // Assert
        map.Locations.Count().ShouldBe(1);
        map.Locations.ShouldContain(location);
    }
}