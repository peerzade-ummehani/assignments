using System;

namespace Interface
{
    interface myinterface
    {
        void MethodOne(); 
    }

    interface mysecondinterface
    {
        void MethodTwo(); 
    }

   
    class democlass : myinterface, mysecondinterface
    {
        public void MethodOne()
        {
            Console.WriteLine("This is the body of 1st Method");
        }
        public void MethodTwo()
        {
            Console.WriteLine("This is the body of 2nd Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            democlass obj = new democlass();
            obj.MethodOne();
            obj.MethodTwo();
        }
    }
}
