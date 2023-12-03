using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooDoList.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ENTER FIRST NUMBER: ");

            string Number1 = Console.ReadLine();

            Console.WriteLine("ENTER OPERATOR[+ - * /]: ");
            
            string Op = Console.ReadLine();

            Console.WriteLine("ENTER SECOND NUMBER: ");

            string Number2 = Console.ReadLine();



            int Num1 = (int)Convert.ToInt64(Number1);

            int Num2 = (int)Convert.ToInt64(Number2);



            switch (Op)
            {
                case "+":
                    int Result1 = Num1 + Num2;
                    Console.WriteLine(Result1);
                    break;

                case "-":
                    int Result2 = Num1 - Num2;
                    Console.WriteLine(Result2);
                    break; 
                
                case "*":
                    int Result3 = Num1 * Num2;
                    Console.WriteLine(Result3);
                    break;
                
                case "/":
                    int Result4 = Num1 / Num2;
                    Console.WriteLine(Result4);
                    break;

                default:
                    Console.WriteLine("ERROR-01110100!!! PLEASE TRY AGAIN...");
                    break;
            }




            Console.ReadLine();

            }








































    }
}
