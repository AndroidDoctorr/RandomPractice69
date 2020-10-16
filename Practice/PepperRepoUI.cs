using Practice.Peppers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PepperRepoUI
    {
        public void DisplayPeppers(List<IPepper> peppers)
        {
            foreach(IPepper pepper in peppers)
            {
                int index = peppers.IndexOf(pepper);
                Console.WriteLine($"{index + 1}. {pepper.Name} - {(pepper.IsSpicy ? "Hot" : "Not hot")}");
            }
        }
    }
}
