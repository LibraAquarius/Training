using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.UnitTest
{
	[TestClass]
	public class TrainingTest
	{
		[TestMethod]
		public void ReturnTrue()
		{
			Assert.AreEqual(2, 2);
		}

		[TestMethod]
		public void ReturnFalse()
		{
			Assert.AreNotEqual(2, 12);
		}
	}
}
