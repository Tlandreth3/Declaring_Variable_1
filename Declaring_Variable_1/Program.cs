using System;

namespace Declaring_Variables_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            /* Variables are something to store data in, so that you can store the data
             * into a bucket and retrieve it easily from the same bucket.
             */

            /*
			int x;
			int y;
			// we are establishing variables here, the "int" signifies that these variables
			// will have numerical integer values

			x = 3;
			y = x + 7;


			//the eual sign is an operator
			// here we are assigning variables values

			Console.WriteLine(y);
			//Now we command the console to read y, which is 10
			*/

            /*
			String myFirstName;
                // We are declaring myFirstName as a string
                //This is called camel case (lower case first word uppercase all others)
                //variable names are case sensitive
                //When using a "var" declaration type, you are essentially letting the computer 
                //decipeher what type of varibale it is
            myFirstName = "Trace";
                //we are now declaring our variable
            Console.WriteLine(myFirstName);
            */


            // Data conversion

            int x = 7;
            //string y = "Trace";
            string y = "5"; //This can be converted into a string
            string myFirstTry = x.ToString() + y;

            //.NET IS smart enough to cancatinate the integer 7 into a string that says "7"

            //int myScondTry = x + y;
            //.NET cannot explicitly express string y as an integer
            //Cs is a strongly typed language - explicit data types

            //int mySecondTry = x + int.Parse(y);
            //this wouldn't work because string y cannot be converted into an int

            int mySecondTry = x + int.Parse(y);


            Console.WriteLine(myFirstTry);
                   


            //Try to avoid IMPLICIT data conversions - use explicit ones

                
    			

			


		}
	}
}
