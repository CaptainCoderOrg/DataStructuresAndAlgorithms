namespace CaptainCoder.Graph;

internal class GameMap : IGameMap
{
    internal GameMap(IEnumerable<string> locations)
    {
        Locations = locations.ToArray();
    }

    public IEnumerable<string> Locations { get; }

    public IEnumerable<string> Options(string location)
    {
        throw new NotImplementedException();
    }
}