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
            Console.WriteLine();
            shop.FoodCart.Foodstuffs.Add(new Crisps());
            shop.FoodCart.Foodstuffs.Add(new Crisps());
            shop.FoodCart.Foodstuffs.Add(new Crisps());
            shop.FoodCart.PrintCart();
            Console.WriteLine();

            shop.FoodCart.CartBalancing();
            Console.WriteLine();

            shop.FoodCart.PrintCart();




        }
        
    }
}