using Practice.Peppers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // casting is using parentheses to turn a type into another type
            int someInt = 5;
            double someDouble = (double) someInt;
            int newInt = (int) Math.Round(someDouble);
            Console.WriteLine(someInt);

            string someString = "$654afdgsh2dsfhg";
            // Parse means break down and look through (usually a string)
            // int stringNum = Int32.Parse(someString);
            // int stringNum = Convert.ToInt32(someString);
            
            int stringNum = StringToInt(someString);
            Console.WriteLine("did it work?");
            Console.WriteLine(stringNum);


            // writeline is not an instance method
            // Console c = new Console();
            // c.WriteLine("");

            // It's static
            Console.WriteLine("static method!");

            Jalapeno jala = new Jalapeno();
            Console.WriteLine(jala.Name);
            Console.WriteLine(jala.IsDried);
            jala.Dry();
            Console.WriteLine(jala.Name);
            Console.WriteLine(jala.IsDried);


            string[] stringArray = { "hello", "hi", "blah blah blah" };
            Console.WriteLine(stringArray);
            Console.WriteLine(stringArray.Contains("hi"));
            // stringArray.Add(); <-- no
            stringArray.Reverse();
            stringArray[0] = "doo doo doo";
            Console.WriteLine(stringArray[0]);

            Console.WriteLine("\n\n");
            List<Jalapeno> pepperBasket = new List<Jalapeno>() { jala };
            pepperBasket.Add(new Jalapeno());
            Console.WriteLine(pepperBasket.Count);
            Console.WriteLine(pepperBasket.IndexOf(jala));
            pepperBasket.RemoveAt(0);
            Console.WriteLine(pepperBasket.Count);
        }

        // static means just one method for the whole class
        public static int StringToInt(string inputString)
        {
            // Classes are reference types
            List<char> digits = new List<char>() { '1','2','3','4','5','6','7','8','9','0' };
            // primitives are value types
            // string, int, char

            string outputString = "";
            foreach(char letter in inputString)
            {
                if (digits.Contains(letter))
                {
                    outputString += letter;
                }
            }

            if (outputString == "")
            {
                return 0;
            } else
            {
                return Int32.Parse(outputString);
            }
        }
    }
}
