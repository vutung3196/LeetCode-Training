using System;

namespace LinkedListImplementation
{
    public class MyFibonancy
    {
        public static int Fibonancy(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonancy(n - 1) + Fibonancy(n - 2);
            }
        }
    }
}
