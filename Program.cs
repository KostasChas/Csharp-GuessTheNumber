using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random(); // generate random numbers

            int WinNum = r.Next(0, 100); // the rundom numbers from 0 to 100

            bool win = false; //set bool to fasle for the win

            do // check the numbers the user gives and act acordingly
            {
                Console.WriteLine("Guess a number between 0 and 100");

                string s = Console.ReadLine();

                int i = int.Parse(s);


                Console.Clear();


                if (i < 0)
                {
                    Console.WriteLine("The number must be above 0");
                }

                else if (i > 100)
                {
                    Console.WriteLine("The number must be below 100");
                }

                else if (i > WinNum)
                {
                    Console.WriteLine("The number  "+ i + "  is too high");
                }

                else if (i < WinNum)
                {
                    Console.WriteLine("The number  " + i + "  is too low");
                }

                else if (i == WinNum)
                {
                    Console.WriteLine("The number  "+ i +"  is the winning number");
                    win = true;
                }

                Console.WriteLine();
                

            }

            while (win == false); // do the loop while the bool is false
            
            Console.WriteLine("Thank you for playing");
            Console.WriteLine("Press any key to end the game");
            Console.ReadKey(true); // wait for use to press a key to end the app


        }
    }
}
