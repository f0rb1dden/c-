using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2PresidentSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Who do you think is the best team in the world. AC Milan, Botev Plovdiv, Tottenham ?");
       
            string fteams = (Console.ReadLine()).ToLower();
            string reply = "";
            switch (fteams)
            {
                case "ac milan":
                    reply = "AMAZING";
                    break;
                case "botev lovdiv":
                    reply = "I agree with you";
                    break;
                case "tottenham":
                    reply = "Is this a joke";
                    break;
                default:
                    reply = "This club is not on the list";
                 break;
                    
            }
            Console.WriteLine(reply);

         

       


        } //end main
    } // end program
 }// end namespace
