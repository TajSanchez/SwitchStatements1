using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenrator = new Random();

            int num01 = numberGenrator.Next(1,11);
            int num02 = numberGenrator.Next(1, 11);

            Console.WriteLine(" What is " + num01 + " times " + num02 + " ? ");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num01 * num02)
            {
                Console.WriteLine("Well done! Your answer is correct.");
            }
            else
            {
                int responseIndex = numberGenrator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                   Console.WriteLine("Are you even trying?");
                        break;
                    case 2:
                        Console.WriteLine("The answer was incorrect.");
                        break;
                    default:
                        Console.WriteLine("You can do better than that!");
                        break;
                }

                
            }
            Console.ReadKey();
        }
    }
}
