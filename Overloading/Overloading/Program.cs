using System;

namespace Overloading
{
    class pgrm

    {
    
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class Overloading
    {
        public static void Main()
        {
            Console.WriteLine(pgrm.add(10,20));
            Console.WriteLine(pgrm.add(14,15,25));
        }
    }
}

