// See https://aka.ms/new-console-template for more information
using CaptainCoder.Graph;

string CaveEntrance = "Cave Entrance";
string DeadEnd = "Dead End";
string Pit = "Pit";
string GameOver = "Game Over";
string Tunnel = "Tunnel";

MapBuilder builder = new MapBuilder();
IGameMap map = builder
    .AddLocation(CaveEntrance)
    .AddLocation(DeadEnd)
    .AddLocation(Pit)
    .AddLocation(GameOver)
    .AddLocation(Tunnel)
    .AddOptions("Go Left", CaveEntrance, DeadEnd)
    .AddOptions("Go Right", CaveEntrance, Pit)
    .AddOptions("Return to Entrance", DeadEnd, CaveEntrance)
    .AddOptions("Lay down and die", Pit, GameOver)
    .AddOptions("Stand up", Pit, Tunnel)
    .Build();

string location = CaveEntrance;
while (location != GameOver)
{
    Console.WriteLine($"Location: {location}");
    GameOption option = GetChoice(map.Options(location).ToArray());
    location = option.Destination;
}

GameOption GetChoice(GameOption[] options)
{
    for (int ix = 0; ix < options.Length; ix++)
    {
        Console.WriteLine($"{ix + 1}. {options[ix].Option}");
    }
    Console.Write("What do: ");
    if(int.TryParse(Console.ReadLine(), out int choice) is false)
    {
        Console.WriteLine("Invalid option.");
        return GetChoice(options);
    }
    // The user typed an integer
    if (choice < 1 || choice > options.Length)
    {
        Console.WriteLine("Invalid option.");
        return GetChoice(options);
    }

    // We know they entered a valid option
    return options[choice - 1];
}