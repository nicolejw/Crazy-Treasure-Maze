using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----This section of code is intended to handle the seed, checks if an argument has been input when running the application.
            //if it has, the game will use the input as the rng seed. If not, the starting positions of the game entities will be set to a default value-------
            int charX= 3;
            int charY=3;
            Random random = new Random();

            Console.Title = "Crazy Treasure Maze";
            int mapX = 10;
            int mapY = 10;
            bool endGame = false;

            while (endGame == false)
            {
                Console.SetCursorPosition(charX, charY);
                Console.Write("S");

                char[,] grid = new char[mapX, mapY];
                for (int x = 0; x < mapX; ++x)
                {
                    for (int y = 0; y < mapY; ++y)
                    {
                        grid[x, y] = ' ';
                    }
                }

                //if (args == null || args.Length == 0)
                //{
                //    charX = 5;
                //    charY = 5;
                //}
                //else
                //{
                //    //---this line is just for checking whether the input is actually grabbed or not, and should just print the value----
                //    //Console.WriteLine(Convert.ToInt32(args));
                //    charX = 2;
                //    charY = 2;
                //}


                Console.Clear();
                ShowGrid(grid);

                ConsoleKeyInfo playerInput = Console.ReadKey(true);
                switch (playerInput.Key)
                {
                    case ConsoleKey.N:
                        if (charY > 0)
                            charY--;
                        break;
                    case ConsoleKey.S:
                        if (charY < 9)
                            charY++;
                        break;
                    case ConsoleKey.W:
                        if (charX > 0)
                            charX--;
                        break;
                    case ConsoleKey.E:
                        if (charX < 9)
                            charX++;
                        break;
                }

                //-------The following code allows player movement through the specified keys, but will not check coordinates against
                //the bounds of our array, resulting in out of bounds moving to the edge of the console (top and left), and allowing any movement within the whole
                //console widow (right and down)--------------------

                //if (playerInput.Key == ConsoleKey.N)
                //{
                //    charY--;
                //}
                //else if (playerInput.Key == ConsoleKey.S)
                //{
                //    charY++;
                //}
                //else if (playerInput.Key == ConsoleKey.W)
                //{
                //    charX--;
                //}
                //else if (playerInput.Key == ConsoleKey.E)
                //{
                //    charX++;
                //}

            }

        }

        static void ShowGrid(char[,] g)
        {
            for (int x = 0; x < 10; ++x)
            {
                for (int y = 0; y < 10; ++y)
                {
                    Console.Write("x", g[x, y]);
                }
                Console.WriteLine();
            }
        }       

        //static void movement()
        //{
        //    bool active = true;
        //    while (active == true)
        //    {
        //        var next = 
        //    }
        //}
    }
}
