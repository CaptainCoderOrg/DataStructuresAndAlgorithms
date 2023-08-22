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

    [Fact]
    public void test_add_option()
    {
        // Arrange
        MapBuilder builder = new MapBuilder();
        builder.AddLocation("Captain Coder's Academy")
               .AddLocation("Death Platform");       

        // Act
        builder.AddOptions("Go to Death Platform", "Captain Coder's Academy", "Death Platform");
        IGameMap map = builder.Build();

        // Assert
        map.Locations.Count().ShouldBe(2);
        map.Locations.ShouldContain("Captain Coder's Academy");
        map.Locations.ShouldContain("Death Platform");
        map.Options("Captain Coder's Academy").Count().ShouldBe(1);
        map.Options("Captain Coder's Academy")
           .ShouldContain(new GameOption("Go to Death Platform", "Death Platform"));
    }

    [Fact]
    public void test_add_multiple_options()
    {
        // Arrange
        MapBuilder builder = new MapBuilder();
        builder.AddLocation("Captain Coder's Academy")
               .AddLocation("Death Platform")
               .AddLocation("Hoboken, NJ")
               .AddLocation("Boss Room");

        // Act
        builder.AddOptions("Go to Death Platform", "Captain Coder's Academy", "Death Platform")
               .AddOptions("Go to New Jersey", "Captain Coder's Academy", "Hoboken, NJ")
               .AddOptions("Fight Boss", "Captain Coder's Academy", "Boss Room");
        IGameMap map = builder.Build();

        // Assert
        map.Locations.Count().ShouldBe(4);
        map.Locations.ShouldContain("Captain Coder's Academy");
        map.Locations.ShouldContain("Death Platform");
        map.Locations.ShouldContain("Hoboken, NJ");
        map.Locations.ShouldContain("Boss Room");

        map.Options("Captain Coder's Academy").Count().ShouldBe(3);
        map.Options("Captain Coder's Academy")
           .ShouldContain(new GameOption("Go to Death Platform", "Death Platform"));

        map.Options("Captain Coder's Academy")
           .ShouldContain(new GameOption("Go to New Jersey", "Hoboken, NJ"));

        map.Options("Captain Coder's Academy")
           .ShouldContain(new GameOption("Fight Boss", "Boss Room"));
    }
}