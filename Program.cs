using System;

namespace Plattform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DrawRoad();
        }

        private static void DrawRoad()
        {
            string road = "|      |";
            
            string car = "V";


            road = road.Insert(1, car);

            Console.WriteLine(road);


            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.RightArrow:
                        break;
                    case ConsoleKey.DownArrow:
                        break;
                    case ConsoleKey.LeftArrow:
                        break;

                }

            }


        }




    }
}
