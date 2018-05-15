using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3thetwoloops
{
    class Program
    {
        static void Main(string[] args)
        {



            string coranswer = "very hard";
            string reply = "";
            int ngues = 0;

            while (reply != coranswer && ngues<3)
            {
                Console.WriteLine("I have riddle for you. Is it hard to become a developer ?");
                reply = Console.ReadLine();
                ngues++;
                if (reply == coranswer)
                {
                    Console.WriteLine("Amazing");
                    break;
                }
                else if (reply != coranswer && ngues < 2);
                {
                    ngues++;
                    Console.WriteLine("YOU have 2 more attempts");
                  
                }
                else if (reply != coranswer && ngues < 1);
                Console.WriteLine("LAST CHANCE BUDDY");
                ngues++;

            }
           













        }//main
    }//program
}//namespace





































    //Console.WriteLine("Who do you think is the best team in the world. AC Milan, Botev Plovdiv, Tottenham ?");

    //string fteams = (Console.ReadLine()).ToLower();
   // string reply = "";
      //      switch (fteams)
       //     {
        //        case "ac milan":
         //           reply = "AMAZING";
         //           break;
         //       case "botev lovdiv":
           //         reply = "I agree with you";
                //    break;
           //     case "tottenham":
              //      reply = "Is this a joke";
                //    break;
             //   default:
             //       reply = "This club is not on the list";
              //   break;
                    
            
//Console.WriteLine(reply);
//
//int myNumber = 17;

//int response = 0;


       //     do
      //      {

      //          Console.WriteLine("Enter numbers in order to guess my magical number from 1 to 20 ^^");
    //            response = Convert.ToInt32(Console.ReadLine());
    ///
     //           if (response == myNumber)
     //
        //        {
       //             Console.WriteLine("Thats my magical number");
        //        }
         //       else if (response > myNumber)
            //    {
           //         Console.WriteLine("My number is lower that this one");
            //    }
             //   else if (response<myNumber)
              //  {
              //      Console.WriteLine("My number is greater than this one");
             //   };
            //    } while (response != myNumber);