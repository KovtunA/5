using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your mark");

            switch (getNumber())
            {
                case int n when (n < 0 || n > 100):
                    Console.WriteLine("Enter correct data. Expected 0-100");
                    break;

                case int n when (n >= 0 && n <= 19):
                    Console.WriteLine("You get F");
                    break;

                case int n when (n <= 39):
                    Console.WriteLine("You get E");
                    break;

                case int n when (n <= 59):
                    Console.WriteLine("You get D");
                    break;

                case int n when (n <= 74):
                    Console.WriteLine("You get D");
                    break;

                case int n when (n <= 89):
                    Console.WriteLine("You get B");
                    break;

                case int n when (n <= 100):
                    Console.WriteLine("You get A");
                    break;
            }

        }

        private static Int32 getNumber()
        {             string userInput = Console.ReadLine();

            try { return Convert.ToInt32(userInput); }             catch             {                 Console.WriteLine("Invalid input, please try again");                 return getNumber();             }         } 
    }
}
