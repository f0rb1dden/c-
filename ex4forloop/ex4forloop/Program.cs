using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4forloop
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            for (int i = 0; i < sevenDwarves.Length; i++)
            {

                //
                string ff = sevenDwarves[i];
                Console.WriteLine("here's your dinner" + ff);
            }
           foreach (string dwarves in sevenDwarves)
                {
                
                Console.WriteLine("here's your drink" + dwarves);
            }
            foreach (string dinnerq in sevenDwarves)
                
            {
                // creating a new string and use it like in the upper foreach and add console.writeline with both strings/

                Console.WriteLine("what would you like for dinner, "  +  dinnerq );
                string dinnermeal = Console.ReadLine();
                Console.WriteLine(" Here is your , " +  dinnermeal + dinnerq );
  
                
          
            }
           












        }
    }
}
