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
		[Test]
		public void atestTest()
		{
			int result = 10;
			int expected = Program.Equals();


		}
		[Test]
		public void seedChecker()
		{
			bool result = Program.seedChk(0);
			bool expected = false;
			Assert.AreEqual(expected, result);

			
		}

	}
}
