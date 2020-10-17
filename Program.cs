using System;

namespace Plattform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StartGame();
            DrawRoad();
        }

        private static void StartGame()
        {
            throw new NotImplementedException();
        }

        private static void DrawRoad()
        {
            string road = "|        |";
            
            string car = "V";

            road = road.Insert(1, car);

            Console.WriteLine(road);
        }
    }
}
