using System;

namespace helloworld.Models
{
	public class MyModel
	{
		public string Greet(string name)
		{
			if(name == null) throw new ArgumentNullException("name");

			return "Hello, " + name + "!!";
		}
	}
}