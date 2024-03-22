using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 210;

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;

                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;

                default:
                    Console.WriteLine("Number is not 10 or 20 or 30");
                    break;
            }
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10 ");
            // }
            //else if (number == 20) 
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}


            // Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
        }
    }
}
