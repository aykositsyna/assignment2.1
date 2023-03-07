using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal interface IFood : IThing
    {
        bool Proteins { get; set; }
        bool Fats { get; set; }
        bool Carbohydrates { get; set; }
    }
}
