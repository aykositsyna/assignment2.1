using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class BalykCheese : ISnacks
    {
        public bool Proteins { get; set; }
        public bool Fats { get; set; }
        public bool Carbohydrates { get; set; }
        public string Name { get; set; }

        public BalykCheese()
        {
            Proteins = true;
            Name = "Cheese balyk";
        }
    }
}
