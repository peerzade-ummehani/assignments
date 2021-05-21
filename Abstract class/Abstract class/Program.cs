using System;

namespace Abstract_class
{
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void food()
        {
            Console.WriteLine("The Dog eat's Meat");
        }
    }

    // Derived class (inherit from Animal)
    class dog : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: Bow Bow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dog  obj = new dog(); // Create a Pig object
            obj.animalSound();  // Call the abstract method
            obj.food();  // Call the regular method
        }
    }
}
