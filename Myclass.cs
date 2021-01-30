using System;

namespace BakeryShoppingCart
{
    internal class Myclass<T>
    {
        public string Myproperty { get; internal set; }
        public int Myproperty2 { get; internal set; }

        internal void PrintSomething()
        {
            throw new NotImplementedException();
        }

        internal void PrintSomethingElse(int v)
        {
            throw new NotImplementedException();
        }
    }
}