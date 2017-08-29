using System;

namespace Declaring_Variables_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			/* Variables are something to store data in, so that you can put the data
             * into a bucket and retrieve it easily from the same bucket.
             */
			int x;
			int y;
			// we are establishing variables here, the "int" signifies that these variables
			// will have numerical integer values

			x = 7;
			y = x + 7;

			//the eual sign is an operator
			// here we are assigning variables values

			Console.WriteLine(y);
			Console.ReadLine();

			//Now we command the console to read y, which is 10


		}
	}
}
