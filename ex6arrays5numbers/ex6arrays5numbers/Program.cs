using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6arrays5numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            double sum =0;
            double avg;

            Console.WriteLine("Please enter 5 numbers to be averaged, pressing return after ");
            for (int i = 0; i < numbers.Length; i++)              
            {               
                Console.WriteLine("Please enter a number");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
               
            }

            avg = sum / numbers.Length;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);

        }
    }
}
