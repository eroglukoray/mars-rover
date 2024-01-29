using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mars Rover is moving !");

            Console.WriteLine("__Test Input:__");
            Console.WriteLine();
            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");
            Console.WriteLine();
            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");
            Console.WriteLine();
            //First rover 
            Plateau plateauOne = new Plateau("5 5");
            Rover firstRover = new Rover("1 2 N", plateauOne);
            firstRover.Move("LMLMLMLMM");

            //Second rover 
            Plateau plateauTwo = new Plateau("5 5");
            Rover secondRover = new Rover("3 3 E", plateauTwo);
            secondRover.Move("MMRMMRMRRM");

            Console.WriteLine("__Expected Output:__");
            Console.WriteLine();
            Console.WriteLine(firstRover.Result());
            Console.WriteLine(secondRover.Result());
            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
