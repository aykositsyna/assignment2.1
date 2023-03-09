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
        public List<T> Foodstuffs { get; }

        private List<IThing> Things; 

        public Cart(List<IThing> things)
        {
            this.Things = things;
        }


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

            if (!proteinExists)
            {
                Console.WriteLine("Not enough protein :(");
            }

            if (!fatsExist)
            {
                Console.WriteLine("Not enough fats :(");
            }

            if (!carbohydratesExist) 
            {
                Console.WriteLine("Not enough carbohydrates :(");
            }

            if (!proteinExists || !fatsExist || !carbohydratesExist) 
            {
                Console.WriteLine("Cart is unbalanced. Wanna balace it? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    bool isBalanced = TryToBalance(!proteinExists, !fatsExist, !carbohydratesExist);
                    if (isBalanced)
                    {
                        Console.WriteLine("Congratulations! Cart is now balanced :)");
                    }
                    else
                    {
                        Console.WriteLine("Oh no, balancing failed :,(");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Your cart is well balanced :)");
            }
        }

        private bool TryToBalance(bool needProteins, bool needFats, bool needCarbohydrates)
        {
            foreach (IThing thing in Things)
            {
                if (thing is T needThing)
                {
                    if (needProteins && needThing.Fats == needProteins)
                    {
                        Foodstuffs.Add(needThing);
                        needProteins = false;
                    }

                    if (needFats && needThing.Fats == needFats)
                    {
                        Foodstuffs.Add(needThing);
                        needFats = false;
                    }

                    if (needCarbohydrates && needThing.Carbohydrates == needCarbohydrates)
                    {
                        Foodstuffs.Add(needThing);
                        needCarbohydrates = false;
                    }

                    if (!(needProteins || needFats || needCarbohydrates))
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        public void PrintCart()
        {
            foreach (T thing in Foodstuffs) 
            {
                Console.WriteLine(thing.Name);
            }
        }
        
    }
}
