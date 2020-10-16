using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Peppers
{
    public interface IPepper
    {
        // Properties
        string Name { get; }
        bool IsSpicy { get; }
        bool IsDried { get; }

        // color
        // scovilleUnits

        // Methods
        void Dry();
    }
}
