using System.Transactions;

namespace MarsRover_TeamA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mars Rover Program!");
        Console.WriteLine("please enter initial coordinates and direction for rover (e.g., 1,2 N)");
        var initalInput = Console.ReadLine();
        var parameters = initalInput.Split(" ");
        var coordinates = parameters[0].Split(",");
        var rover = new Rover( int.Parse(coordinates[0]), int.Parse(coordinates[1]), parameters[1]);
        Console.WriteLine(rover);
        Console.WriteLine("Please enter movement commands");
        Console.ReadLine();
    }
}
