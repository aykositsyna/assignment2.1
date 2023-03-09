using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal interface IFood : IThing
    {
        bool Proteins { get; }
        bool Fats { get; }
        bool Carbohydrates { get; }
    }
}
