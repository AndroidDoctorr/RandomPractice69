using Practice.Peppers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PepperRepo
    {
        private List<IPepper> _basket = new List<IPepper>();
        //C
        public void AddAPepper(IPepper pepper)
        {
            _basket.Add(pepper);
        }
        //R
        public List<IPepper> GetPeppers()
        {
            return _basket;
        }

        //U
        public void DryPepperAt(int index)
        {
            IPepper pepper = _basket[index];
            pepper.Dry();
        }
    }
}
