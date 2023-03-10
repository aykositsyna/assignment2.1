using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class BalykCheese : ISnacks
    {
        public bool Proteins => true;
        public bool Fats => false;
        public bool Carbohydrates => false;
        public string Name => "Cheese balyk";
    }
}
