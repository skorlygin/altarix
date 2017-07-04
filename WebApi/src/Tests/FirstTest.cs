using NUnit.Framework;

namespace Tests
{
	public class FirstTest
	{
		[Test]
		public void PassingTest()
		{
			Assert.AreEqual(2, 1 << 1);
		}

		[Test]
		public void FailingTest()
		{
			Assert.AreEqual(2, 1 >> 1);
		}
	}
}
