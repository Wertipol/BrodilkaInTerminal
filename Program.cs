using System;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            char[,] map =
            {
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                { '#',' ',' ','*',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#','#','#','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                { '#','#',' ','#','#','#','#','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','*','*',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','^','^','^',' ',' ','#',' ',' ','*',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ','#',' ','^','*',' ',' ',' ',' ','#','*',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                { '#','*',' ',' ',' ','#',' ','^',' ',' ',' ','*',' ',' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ','*','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };
            int userX = 2, userY = 2;
            int coins = 0;

            while (coins != 10)
            {
                Console.SetCursorPosition(5, 20);
                Console.WriteLine($"Монеты: {coins}");
                Console.WriteLine("Надо собрать 10 монет");
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo action = Console.ReadKey();
                switch (action.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                }
                if (map[userX, userY] == '*')
                {
                    map[userX, userY] = ' ';
                    coins++;
                }
                else if (map[userX, userY] == '^')
                {
                    coins = 10;
                }
                Console.Clear();
            }
            Console.WriteLine("Игра окончена");
            Console.ReadKey();
        }
    }
}
