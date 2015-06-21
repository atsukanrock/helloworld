using System;
using NUnit.Framework;

namespace helloworld.Models
{
	[TestFixture]
	public class MyModelTests
	{
		[TestCase("atsukanrock", "Hello, atsukanrock!!")]
		[TestCase("Sansan", "Hello, Sansan!!")]
		public void GreetShouldWorkAsExpected(string name, string expected)
		{
			var that = new MyModel();
			var actual = that.Greet(name);
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		public void GreetShouldThrowArgumentNullExceptionIfNameIsNull()
		{
			var that = new MyModel();
			Assert.Throws<ArgumentNullException>(() => that.Greet(null));
		}
	}
}