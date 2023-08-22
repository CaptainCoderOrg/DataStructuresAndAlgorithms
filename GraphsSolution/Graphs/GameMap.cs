namespace CaptainCoder.Graph;

internal class GameMap : IGameMap
{
    private readonly Dictionary<string, IEnumerable<GameOption>> _options;
    internal GameMap(IEnumerable<string> locations, IReadOnlyDictionary<string, IEnumerable<GameOption>> options)
    {
        Locations = locations.ToArray();
        _options = new Dictionary<string, IEnumerable<GameOption>>();
        foreach ((string location, IEnumerable<GameOption> locationOptions) in options)
        {
            _options[location] = locationOptions.ToArray();
        }
        // _options = options;
    }

    public IEnumerable<string> Locations { get; }
    

    public IEnumerable<GameOption> Options(string location)
    {
        return _options[location];
    }
}