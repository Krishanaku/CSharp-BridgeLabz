using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class UserName
    {
        public static string Stri = "Krishna";
        public static void name()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            if (name.Length > 3)
            {
                Console.WriteLine("Hello {0} ,How are you ", name);

            }
            else
            {
                Console.WriteLine("The name is not having minumum 3 char!!");

            }
        }
    }
}
