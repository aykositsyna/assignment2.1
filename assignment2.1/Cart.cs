using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class Cart<T>
        where T : IFood
    {
        public List<T> Foodstuffs;


        public void CartBalancing()
        {
            bool proteinExists = false;
            bool fatsExist = false;
            bool carbohydratesExist = false;

            foreach (T foodstuff in Foodstuffs)
            {
                proteinExists = foodstuff.Proteins || proteinExists;
                fatsExist = foodstuff.Fats || fatsExist;
                carbohydratesExist = foodstuff.Carbohydrates || carbohydratesExist;
            }

            if (proteinExists)
            {
                Console.WriteLine("Not enough protein :(");
            }

            if (fatsExist)
            {
                Console.WriteLine("Not enough fats :(");
            }

            if (carbohydratesExist) 
            {
                Console.WriteLine("Not enough carbohydrates :(");
            }

            if (proteinExists && fatsExist && carbohydratesExist) 
            {
                Console.WriteLine("Cart is unbalanced. Wanna balace it? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    //start balancing
                }
                
            }
            else
            {
                Console.WriteLine("Your car is well balanced :)");
            }
        }
        
    }
}
