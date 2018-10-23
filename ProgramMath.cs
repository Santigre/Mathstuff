using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number!");
            string userNumber = Console.ReadLine();
            int numberValue = Convert.ToInt32(userNumber);
            int multiply = numberValue * 50;
            Console.WriteLine(userNumber + " Multiplied by fifty equals " + multiply);

            Console.WriteLine("Pick an other number!");
            string secNumber = Console.ReadLine();
            int secValue = Convert.ToInt32(secNumber);
            int add = secValue + 25;
            Console.WriteLine(secNumber + " Pluse 25 equals " + add);

            Console.WriteLine("Pick an other number!");
            string thirdNumber = Console.ReadLine();
            double thirdValue = Convert.ToDouble(thirdNumber);
            double div = thirdValue / 12.5;
            Console.WriteLine(thirdNumber + " Divided by 12.5 equals " + div);

            Console.WriteLine("Pick an other number!");
            string forthNumber = Console.ReadLine();
            int forthValue = Convert.ToInt32(forthNumber);
            bool greaterThan = forthValue > 50;
            Console.WriteLine("Is " + forthNumber + " greater than 50? " + greaterThan);

            Console.WriteLine("Pick an other number!");
            string fithNumber = Console.ReadLine();
            int fithValue = Convert.ToInt32(fithNumber);
            int remainder = fithValue % 7;
            Console.WriteLine("Seven goes into " + fithNumber + " evenly with a remainder of " + remainder);



            Console.ReadLine();
        }
    }
}
