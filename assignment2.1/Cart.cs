using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class Cart<T> where T : IFood
    {
        public List<T> Foodstuffs { get; }

        private List<IThing> Things; 

        public Cart(List<IThing> things)
        {
            this.Things = things;
            Foodstuffs = new List<T>();
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

            if (!proteinExists || !fatsExist || !carbohydratesExist)
            {
                TryToBalance(!proteinExists, !fatsExist, !carbohydratesExist);
            }   
        }

        private bool TryToBalance(bool needProteins, bool needFats, bool needCarbohydrates)
        {
            
            foreach (IThing thing in this.Things)
            {
                if (thing is T needThing)
                {
                    if (needProteins && needThing.Proteins == needProteins)
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

        public string PrintCart()
        {
            string result = string.Empty;
            foreach (T thing in Foodstuffs)
            {
                result += (thing.Name) + "\n";
            }
            return result;
        }

    }
}
