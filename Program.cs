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
            DrawRoad();
        }

        private static void DrawRoad(int one = 1)
        {

            string road = "|        |";
            
            string car = "V";

            while(one == 1)
            {
                road = road.Insert(one, car);
                Console.WriteLine(road);
                Console.ReadLine();
            }
        }
    }
}
