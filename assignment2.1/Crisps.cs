using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class Crisps : ISnacks
    {
        public bool Proteins => false;
        public bool Fats => true;
        public bool Carbohydrates => false;
        public string Name => "Crisps";
    }
}
