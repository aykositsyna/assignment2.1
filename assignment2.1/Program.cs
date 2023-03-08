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

            switch (choice)
            {
                case "2":
                    shop.GetCart<ISnacks>(ref shop.FoodCart);
                case "3":
                    shop.GetCart<IHealthyFood>(ref shop.FoodCart);
                case "4":
                    shop.GetCart<ISemiFinishedFood>(ref shop.FoodCart);
            }

        }
        
    }
}