namespace CaptainCoder.Graph;

public class MapBuilder
{
    private HashSet<string> _locations = new ();
    // Dictionary is a HashTable (HashMap in Java)
    public MapBuilder AddLocation(string location)
    {
        _locations.Add(location);
        return this;
    }

    public MapBuilder AddOptions(string optionName, string start, string end)
    {
        throw new NotImplementedException();
        return this;
    }

    public IGameMap Build()
    {
        return new GameMap(_locations);
    }
}