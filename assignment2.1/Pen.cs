using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class Pen : IThing
    {
        public string Name { get; set; }

        public Pen()
        {
            Name = "Pen";
        }
    }
}
