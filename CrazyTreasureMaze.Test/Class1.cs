using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CrazyTreasureMaze.Test
{
	[TestFixture]
	public class testSuite
	{
		[Test]
		public void arrayDrawn()
		{
			//Arrange
			int x = 10;
			int y = 10;
			//Act
			int output = x + y;
			//Assert
			Assert.AreEqual(x, y);
		}
		[Test]
		public void seedChecker()
		{
			//Arrange

			//Act

			//Assert
		}

	}
}
