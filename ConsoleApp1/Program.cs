using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Program
	{
		static void Main(string[] args)
		{
			//int seed = 1;
			//TODO player/ghost collision, treasure and goblin placement thanks
			Console.Title = "Crazy Treasure Maze";
			bool endGame = false;
			bool move = false;
			int charX;
			int charY;
			int ghostX;
			int ghostY;
			int mapX = 10;
			int mapY = 10;
			int seed;
			//string argsHolder = args[0];
			if (args == null)
			{
				seed = Int32.Parse(args[0]);
			}
			else
			{
				seed = 0;
			}
			Random random = new Random(seed);
			seedChk(seed);

			//-----This section of code is intended to handle the seed, checks if an argument has been input when running the application.
			//if it has, the game will use the input as the rng seed. If not, the starting positions of the game entities will be set to a default value-------
			if (seed == 0)
			{
				charX = 1;
				charY = 1;
				ghostX = 5;
				ghostY = 5;
			}
			else
			{
				//---this line is just for checking whether the input is actually grabbed or not, and should just print the value----
				//Console.WriteLine(args);
				charX = random.Next(1, 10);
				charY = random.Next(1, 10);
				ghostX = random.Next(1, 10);
				ghostY = random.Next(1, 10);
			}

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
				Others.ShowGrid(grid);
				//Others.coordChecker(charX);
				//Others.coordChecker(charY);
				Console.WriteLine(Convert.ToString(charX), charY);
				Console.SetCursorPosition(charX, charY);
				Console.Write("S");
				//Console.ReadKey();
				Console.SetCursorPosition(ghostX, ghostY);
				Console.Write("G"); //------- The ghost is drawn as a G for testing purposes, but will be changed to an x later-------

				//-------This switch statement is for the player movement, keeping the player within the grid while allowing movement. The input is not case sensitive-----
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
				//------This switch statement controls how the ghost moves, using out rng seed to grab one of four numbers which makes the ghost move to one of four directions only when the player moves-----
				ConsoleKeyInfo ghostMove = Console.ReadKey(true);
				int newPos = random.Next(4);
				switch (ghostMove.Key)
				{

					case ConsoleKey.N:
						if (ghostY > 0)
							if (newPos == 1)
							{
								ghostY--;
							}
						if (ghostY > 0)
						{
							if (newPos == 2)
							{
								ghostY++;
							}
						}
						if (ghostY > 0)
						{
							if (newPos == 3)
							{
								ghostX--;
							}
						}
						if (ghostY > 0)
						{
							if (newPos == 4)
							{
								ghostX++;
							}
						}
						break; //-----The above is to test randomization of the ghosts movement. Probably contains needless code/theres an easier way of 
							   //doing this? -----
					case ConsoleKey.S:
						if (ghostY < 9)
							if (newPos == 1)
							{
								ghostY--;
							}
						if (ghostY < 9)
							if (newPos == 2)
							{
								ghostY++;
							}
						if (ghostY < 9)
							if (newPos == 3)
							{
								ghostX--;
							}
						if (ghostY > 9)
							if (newPos == 4)
							{
								ghostX++;
							}
						break;
					case ConsoleKey.W:
						if (ghostX > 0)
							if (newPos == 1)
							{
								ghostY--;
							}
						if (ghostX > 0)
							if (newPos == 2)
							{
								ghostY++;
							}
						if (ghostX > 0)
							if (newPos == 3)
							{
								ghostX--;
							}
						if (ghostX > 0)
							if (newPos == 4)
							{
								ghostX++;
							}
						break;
					case ConsoleKey.E:
						if (Npc.wallCheck(ghostX) == false)
							if (newPos == 1)
							{
								ghostY--;
							}
						if (Npc.wallCheck(ghostX) == false)
							if (newPos == 2)
							{
								ghostY++;
							}
						if (Npc.wallCheck(ghostX) == false)
							if (newPos == 3)
							{
								ghostX--;
							}
						if (Npc.wallCheck(ghostX) == false)
							if (newPos == 4)
							{
								ghostX++;
							}
						break;
				}
				//-------The following code allows player movement through the specified keys, but will not check coordinates against
				//the bounds of our array, resulting in out of bounds errors when moving to the edge of the console (top and left), and allowing any movement within the whole
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
		public class Npc
		{
			int npcY;
			int npcX;

			public int getNpc()
			{
				return npcY;
				return npcX;
			}
			public static bool wallCheck(int toCheck)
			{
				if (toCheck > 9)
				{
					return true;
				}
				if (toCheck < 0)
				{
					return true;
				}
				else
				{
					return false;
				}

			}

		}
		public static bool seedChk(int toCheck)
		{
			if (toCheck == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public class Others
		{

			public static void ShowGrid(char[,] g)
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


		}
		//public static void seedCheck(int valueToCheck)
		//{
		//	Console.Write(valueToCheck.ToString());
		//}
		//static void rngGen(Random ra)
		//{
		//    for (int)
		//}

		//static void seedGen(int seed)
		//{
		//    Random random = new Random(seed);
		//}
		
	}
}
