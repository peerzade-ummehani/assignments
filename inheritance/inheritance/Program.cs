using System;

namespace inheritance
{
    public class student
    {
        public int roll;
        public String name, grade;

        public void input()
        {
            Console.Write("Enter Roll number:");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student name:");
            name = Console.ReadLine();
            Console.Write("Enter Student grade:");
            grade = Console.ReadLine();
        }
    }

    public class College : student
    {
        public void disp()
        {
            Console.WriteLine("\n==============Student Details ===========");
            Console.WriteLine("Roll number is :" + roll);
            Console.WriteLine("College name is :" + name);
            Console.WriteLine("Student name is :" + grade);
        }

        public static void Main(string[] args)
        {
            College stud = new College();
            stud.input();
            stud.disp();
           
        }






    }
}