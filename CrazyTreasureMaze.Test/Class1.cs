using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp1;

namespace CrazyTreasureMaze.Test
{
	[TestFixture]
	public class testSuite
	{
		//[Test]
		//public void arraySizeChecker()
		//{
		//	//int result = 10;
		//	//int expected = Program.Equals(Program.Others.ShowGrid(char[10,10]));
		//	//Assert.AreEqual(expected, result);
		//	//---------nott entierly sure how to test the array, since it is made of char instead of an int---------
		//	//Maybe useing .Length?
		//}
		[Test]
		public void seedChecker()
		{
			bool result = Program.seedChk(0);
			bool expected = false;
			Assert.AreEqual(expected, result);

			
		}
		[Test]
		public void wallCheckTest1()
		{
			var npc = new Program.Npc();
			var result = Program.Npc.wallCheck(10);
			var expected = false;
			Assert.IsFalse(expected);
			
		}
		[Test]
		public void wallCheckTest2()
		{
			var npc = new Program.Npc();
			var result = Program.Npc.wallCheck(-1);
			var expected = false;
			Assert.IsFalse(expected);

		}
		//[Test]
		//public void wallCheck_NullTest()
		//{
		//	bool result = Program.Npc.wallCheck(-5);
		//	//bool expected = true;
		//	//Assert.IsTrue();
		//}

	}
}
