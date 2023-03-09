using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._1
{
    internal class Program
    {
       public static void Main(string[] args)
       {
            U_Market shop = new U_Market();
            shop.PrintThings();

            Console.WriteLine("Choose category:\n1 - All food items\n2 - Snacks\n3 - Healthy products\n4 - Semifinished food\n");

            string choice = Console.ReadLine();

            Cart<IFood> newCart;

            switch (choice)
            {
                case "2":
                    Cart<ISnacks> newCartSn;
                    shop.GetCart<ISnacks>(out newCartSn);
                    shop.FoodCart = newCartSn;
                    break;
                case "3":
                    Cart<IHealthyFood> newCartHf;
                    shop.GetCart<IHealthyFood>(out newCartHf);
                    break;
                case "4":
                    Cart<ISemiFinishedFood> newCartSf;
                    shop.GetCart<ISemiFinishedFood>(out newCartSf);
                    break;
            }

        }
        
    }
}