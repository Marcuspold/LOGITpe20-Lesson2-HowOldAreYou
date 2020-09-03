using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What's Your Name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
            Console.WriteLine("What Is Your Year Of Birth?");
            string Userinput;
            Userinput = Console.ReadLine();
            int YearOfBirth;
            //parsing string to interger (number)
            YearOfBirth = Int32.Parse(Userinput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You are " + Age + "old.");



           
        }
    }
}
