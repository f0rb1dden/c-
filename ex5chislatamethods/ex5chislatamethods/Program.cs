using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5chislatamethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn1;
            char sign;
            int fn2;
            decimal result = 0M;

            Console.WriteLine("This program will do simple arithmetic for you if you enter 2 numbers and a sign (+ - * /");
            Console.WriteLine("Please enter the first number:");
            fn1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a sign:");
            sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            fn2 = Convert.ToInt32(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    result = AddNumbers(fn1, fn2);
                    break;
                case '-':
                    result = TakeNumbers(fn1, fn2);
                    break;
                case '/':
                    result = DiversionNumbers(fn1, fn2);
                    break;
                case '*':
                    result = ddoubleNumbers(fn1, fn2);
                    break;
            }
            Console.WriteLine(result);
        }
        static decimal AddNumbers(int fn1, int fn2)
        {
            decimal result = (fn1 + fn2);
            return result;
        }
        static decimal TakeNumbers(int fn1, int fn2)
        {
            decimal result = (fn1 - fn2);
            return result;
        }
        static decimal DiversionNumbers(int fn1, int fn2)
        {
        decimal result = (fn1 / fn2);
        return result;
        }
        static decimal ddoubleNumbers (int fn1, int fn2)
        {
            decimal result = (fn1 * fn2);
            return result;
        }
        }
}
































   // Console.WriteLine("Who do you think is the best team in the world. AC Milan, Botev Plovdiv, Tottenham ?");
       
      //      string fteams = (Console.ReadLine()).ToLower();
  //  string reply = "";
     //       switch (fteams)
      //      {
        //        case "ac milan":
        ////            reply = "AMAZING";
        //            break;
         //       case "botev lovdiv":
           //         reply = "I agree with you";
            // /       break;
            //    case "tottenham":
             //       reply = "Is this a joke";
                //    break;
             //   default:
             //       reply = "This club is not on the list";
             //    break;
                    
            
//Console.WriteLine(reply);









