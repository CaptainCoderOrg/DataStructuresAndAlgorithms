namespace CaptainCoder.Graph;

public class MapBuilder
{
    
    public MapBuilder AddLocation(string location)
    {
        return this;
    }

    public MapBuilder AddOptions(string optionName, string start, string end)
    {
        throw new NotImplementedException();
        return this;
    }

    public IGameMap Build()
    {
        return new GameMap();
    }
}