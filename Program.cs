﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PLOAFER
{
    class Program
    {
        static void Main()
        {
            List<string> mylist = new List<string>();
            mylist.Add("user_1");
            mylist.Add("user_2");
            mylist.Add("user_3");
            mylist.Add("user_4");
            mylist.Add("user_5");
            mylist.Add("user_6");

            string result = mylist.Select(number => number).First();

            Console.WriteLine(result);












































        }
    }
}
