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

        public Cart<ISnacks> FoodCart { get; set; }

        public U_Market()
        {
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
            FoodCart = new Cart<ISnacks>(Things);
        }

        public string PrintThings()
        {
            string allitems = string.Empty;
           allitems += "All items:\n";

            foreach (IThing thing in Things)
            {
                allitems += (thing.Name) + "\n";
            }
            return allitems;
        }

        public void GetCart<T>(out Cart<T> cart) where T : IFood
        {
            cart = new Cart<T>(this.Things);
        }

   
    }
}
