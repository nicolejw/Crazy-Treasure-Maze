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
            int mapX = 10;
            int mapY = 10;
            Console.Title = "Crazy Treasure Maze";
            int charX = 5;
            int charY = 5;
            bool endGame = false;

            while (endGame == false)
            {
                char[,] grid = new char[mapX, mapY];
                for (int x = 0; x < mapX; ++x)
                {
                    for (int y = 0; y < mapY; ++y)
                    {
                        grid[x, y] = ' ';
                    }
                }
                Console.Clear();
                ShowGrid(grid);
                //Console.Read();
                Console.SetCursorPosition(charX, charY);
                Console.Write("S");
                //grid[3, 3] = 'S';


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
