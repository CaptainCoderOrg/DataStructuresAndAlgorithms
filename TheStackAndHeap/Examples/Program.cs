
// See https://aka.ms/new-console-template for more information

// while(true);
ClassExample();


void ClassExample()
{

    Position position = new Position(5, 3);
    Position position2 = position;
    Position position3 = position;
    Console.WriteLine(position);
    ShiftPosition(position);
    ShiftPosition(position);
    ShiftPosition(position);
    Console.WriteLine(position);
    // When Position is a class Outputs X: 8, Y: 3
    // When Position is a struct Outputs: X 5, Y: 3

    void ShiftPosition(Position position)
    {
        position . X++;
    }
}


void BasicStackExample()
{
    int bananas = 5;
    // bananas++;
    // bananas++;
    // bananas++;
    // bananas++;
    Increment(bananas);
    Increment(bananas);
    Increment(bananas);
    Increment(bananas);
    Console.WriteLine(bananas); // outputs 5
    void Increment(int i)
    {
        i++;
        // i = i + 1;
    }
}


// 5! => 5 * 4!             //4 * 3 * 2 * 1
// 4! =>     4 * 3 * 2 * 1
// 3! =>     3 * 2 * 1
int Factorial(int n)
{
    if (n == 1) { return 1; }
    return n * Factorial(n - 1);
}