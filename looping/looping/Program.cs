using System;

namespace looping
{
    using System;



    public class looping
    {


        public void forloop()
        {
            Console.Write("Number is displaying by using for loop \n");
            for (int n = 0; n <= 10; n++)
            {
                Console.Write("\n" + n + "\n");
            }


        }
        public void whileloop()
        {
            Console.Write("Number is displaying by using while loop \n");
            int n = 0;
            while (n <= 10)
            {
                Console.WriteLine("\n" + n + "\n");
                n++;
            }


        }

        public void Dowhileloop()
        {
            Console.Write("Number is displaying by using Do while loop \n");
            int n = 0;

            do
            {
                Console.WriteLine("\n"+n+"\n");
                n++;
            } while (n <= 10);



        }








    }
        public class drive: looping
        {
           
            public static void Main(string[] args)
            {
                drive obj = new drive();
                obj.forloop();
                obj.whileloop();
                obj.Dowhileloop();  
            }






        }
  
}
