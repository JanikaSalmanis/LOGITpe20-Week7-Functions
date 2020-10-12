using System;

namespace gender
{
    class Program
    {
        static void Main(string[] args)
        {
            /*write a program that asks users gender:
             *m for male
             *f for male
             *the program greets the users by assuming
             *the gender provided:
             *"hello, sir!"
             *"hello, madam!"*/
            Console.WriteLine("Whrite m for male, f for female:");
            string userInput = Console.ReadLine();
            Hello(userInput);
        }
        public static void Hello(string gender)
        {
            if(gender == "f")
            {
                Console.WriteLine("Hello, madam!");
            }else if (gender == "m")
            {
                Console.WriteLine("Hello, sir!");
            }
            else
            {
                Console.WriteLine("Hello, magical unicorn!");
            }
        }
    }
}
