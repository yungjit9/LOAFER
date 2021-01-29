using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;
using System.Collections.Generic;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            int[] myArray = new int[10];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;
            myArray[5] = 6;
            myArray[6] = 7;
            myArray[7] = 8;
            myArray[8] = 9;
            myArray[9] = 10;


            Console.WriteLine("The values on the array are the following:");
            foreach(var item in myArray)
            {
                Console.Write(item + ",");
            }

            List<string> mylist = new List<string>();
            mylist.Add("value 1");
            mylist.Add("value 2");
            mylist.Add("value 3");
            mylist.Add("value 4");
            mylist.Add("value 5");
            mylist.Add("value 6");
            mylist.Add("value 7");
            mylist.Add("value 8");
            mylist.Add("value 9");
            mylist.Add("value 10");

            Console.WriteLine("The values on the list are the following:");
            foreach (var item in myArray)
            {
                Console.WriteLine(item + ", ");
            }



        }
    }
}
