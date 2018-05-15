using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 17;

            int response = 0;


            do
            {

                Console.WriteLine("Enter numbers in order to guess my magical number from 1 to 20 ^^");
                response = Convert.ToInt32(Console.ReadLine());

                if (response == myNumber)

                {
                    Console.WriteLine("Thats my magical number");
                }
                else if (response > myNumber)
                {
                    Console.WriteLine("My number is lower that this one");
                }
                else if (response < myNumber)
                {
                    Console.WriteLine("My number is greater than this one");
                };
                } while (response != myNumber);

            



        }
    }
}
