namespace CaptainCoder.Graph;

public interface IGameMap
{
    public IEnumerable<string> Locations { get; }
    public IEnumerable<GameOption> Options(string location);
}