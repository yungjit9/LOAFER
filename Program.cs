using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            List<Cake> mylist = new List<Cake>(); 

            Cake myFirstCake = new Cake();
            myFirstCake.CakeId = 1;
            myFirstCake.Flavor = "chocolate";
            myFirstCake.Form = "square";
            myFirstCake.Size = "medium";
            myFirstCake.Type = "wedding cake";

            mylist.Add(myFirstCake);

            Cake result = mylist.Select(Cake => Cake).First();

            Console.WriteLine(result.Form);



           
        }
    }
}
