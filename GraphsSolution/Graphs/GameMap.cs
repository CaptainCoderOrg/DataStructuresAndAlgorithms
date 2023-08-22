namespace CaptainCoder.Graph;

internal class GameMap : IGameMap
{
    public IEnumerable<string> Locations => new string[] { "Captain Coder's Academy" };

    public IEnumerable<string> Options(string location)
    {
        throw new NotImplementedException();
    }
}