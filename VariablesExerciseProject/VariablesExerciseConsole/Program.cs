using System;

namespace VariablesExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jake";
            int age = 30;
            char number = (char)12;
            bool isHuman = true;
            double numOfCars = 3.0;
            decimal pi = 3.14m;
            

            Console.WriteLine($"My name is {name} and I am {age} years old. I have {numOfCars} cars in my yard.");
        }
    }
}
