using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class Fruit : IHealthyFood
    {
        public bool Proteins => false;
        public bool Fats => false;
        public bool Carbohydrates => true;
        public string Name => "Fruit";
    }
}
