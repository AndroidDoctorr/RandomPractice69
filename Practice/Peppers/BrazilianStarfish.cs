using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Peppers
{
    public class BrazilianStarfish : IPepper
    {
        public string Name { get; private set; } = "Brazilian Starfish";
        public bool IsSpicy { get { return false; } }
        public bool IsDried { get; private set; } = false;

        public void Dry()
        {
            IsDried = true;
            Name = "Dried Brazilian Starfish";
        }
    }
}
