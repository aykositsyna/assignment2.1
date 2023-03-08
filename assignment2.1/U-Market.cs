using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class U_Market
    {
        public List<IThing> Things { get; set; }

        public Cart<IFood> FoodCart { get; set; }

        public U_Market()
        {
            FoodCart = new Cart<IFood>(this.Things);
            Things = new List<IThing>()
            {
                new Cheburek(),
                new BalykCheese(),
                new Chicken(),
                new ChocolateBar(),
                new Crisps(),
                new DumplingsBerries(),
                new DumplingsMeat(),
                new Fruit(),
                new OliveOil(),
                new Pen(),
                new Notebook()
            };
        }
    }
}
