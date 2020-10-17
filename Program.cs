using System;

namespace Plattform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StartGame();
                
        }
        private static void StartGame()
        {
            

            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: // ENUM
                        DrawRoad(ConsoleKey.UpArrow);
                        break;
                    case ConsoleKey.RightArrow: // skicka en parameter (consolekey) till drawroad
                        DrawRoad(ConsoleKey.RightArrow);
                        break;
                    case ConsoleKey.DownArrow:
                        DrawRoad(ConsoleKey.DownArrow);
                        break;
                    case ConsoleKey.LeftArrow:
                        DrawRoad(ConsoleKey.LeftArrow);

                        break;
                }
            }
        }

        private static void DrawRoad(ConsoleKey key)// instans 
        {
            int position = 0;
           if (key == ConsoleKey.LeftArrow)
            {
                position = -1;
            }

            string road = "|        |";
            
            string car = "V";

            Console.WriteLine(road);

            while(true)
            {
                road = road.Insert(position, car);
                Console.WriteLine(road);
                Console.ReadLine();
            }
        }
    }
}
