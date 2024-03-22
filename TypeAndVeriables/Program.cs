using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVeriables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double number6 = 10.4;
            decimal number7 = 10.4m;
            char  character = 'A';
            string city = "Ankara";
            bool condition = true;
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 2147483647;
            long number2 = 922337203685547757;
            var number8 = 10;
            number8 = 'A';

            Console.WriteLine("number1 is {0}",number1);
            Console.WriteLine("number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is ", condition);
            Console.WriteLine("Number8 is {0}", number8);
            Console.WriteLine("Character is : {0}" ,character);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine((int)Days.Friday);
        }
        enum  Days
        {
            Mnonday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
