using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Peppers
{
    public class ChocolateHabanero : IPepper
    {
        public string Name { get; private set; } = $"Chocolate Haba{(char)241}ero";
        public bool IsSpicy { get { return true; } }
        public bool IsDried { get; private set; }
        public void Dry()
        {
            Console.WriteLine("Ow, my eyes!! *cough*");
            IsDried = true;
            Name = $"Dried Chocolate Haba{(char)241}ero";
        }
    }
}
