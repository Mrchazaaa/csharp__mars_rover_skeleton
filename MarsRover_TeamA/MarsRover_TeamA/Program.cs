using System.Transactions;

namespace MarsRover_TeamA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mars Rover Program!");
        Console.WriteLine("Please enter your initial position in formate X Y D (e.g., 1 2 N)");
        var initalInput = Console.ReadLine();
    }
}
