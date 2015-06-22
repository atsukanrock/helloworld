using System;

namespace helloworld.Models
{
	public class MyModel
	{
		public string Greet(string name)
		{
			if (name == null) throw new ArgumentNullException("name");
			if (name.Length == 0) throw new ArgumentException("Cannot be empty.", "name");

			return "Hello, " + name + "!!";
		}
	}
}