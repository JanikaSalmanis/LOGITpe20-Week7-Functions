using System;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a function that takes in users year og birth, calculates and displays the users age*/
            Console.WriteLine("Enter your year of birth:");
            string userInput = Console.ReadLine();
            CalculateAge(userInput);
        }
        public static void CalculateAge(string yearOfBirth)
        {
            int usersYearOfBirth = Int32.Parse(yearOfBirth);
            Console.WriteLine($"you are {2020 - usersYearOfBirth} years old");

        }
    }
}
