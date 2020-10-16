using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Peppers
{
    public class Jalapeno : IPepper
    {
        // public string Name { get { return "Jalape" + (char) 164 + "o"; } }
        public string Name { get; private set; } = "Jalape" + (char) 241 + "o";
        public bool IsSpicy { get { return true; } }
        public bool IsDried { get; private set; } = false;

        public void Dry() {
            IsDried = true;
            Name = "Dried Jalape" + (char) 241 + "o";
        }

        // Instance method - particular pepper
        public void TellMeYourName()
        {
            Console.WriteLine("My name is " + Name);
        }
        // Static method - all peppers
        public static void SingThePepperSong() {
            Console.WriteLine("Hooray I love peppers");
        }

        public Jalapeno()
        {
            Name = "Jalape" + (char)241 + "o";
        }
    }
}
