namespace CaptainCoder.Graph;

public class MapBuilder
{
    private HashSet<string> _locations = new ();
    private Dictionary<string, IEnumerable<GameOption>> _options = new ();
    // Dictionary is a HashTable (HashMap in Java)
    public MapBuilder AddLocation(string location)
    {
        _locations.Add(location);
        _options[location] = new List<GameOption> ();
        return this;
    }

    public MapBuilder AddOptions(string optionName, string start, string destination)
    {
        (_options[start] as List<GameOption>)!.Add(new GameOption(optionName, destination));
        return this;
    }

    public IGameMap Build()
    {
        return new GameMap(_locations, _options);
    }
}