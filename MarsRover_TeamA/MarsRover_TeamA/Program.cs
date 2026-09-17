using System.Transactions;

namespace MarsRover_TeamA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mars Rover Program!");
        Console.WriteLine("please enter initial coordinates and direction for rover (e.g., 1,2 N)");
        var input = Console.ReadLine();
        var parameters = input.Split(" ");
        var coordinates = parameters[0].Split(",");
        var rover = new Rover( int.Parse(coordinates[0]), int.Parse(coordinates[1]), parameters[1]);

        while (true)
        {
            Console.WriteLine(rover);
            Console.WriteLine("Please enter movement commands");

            input = Console.ReadLine();

            if (input.Equals("F"))
            {
                rover.MoveForward();
            }
        }
    }
}
