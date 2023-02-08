using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LeapYear
    {
        public static void LYearorNot()
        {
            Console.WriteLine("Enter your year to check LeapYear OR Not :-");
            string num = Console.ReadLine();
            int lYear = Convert.ToInt32(num);

            if (lYear % 4 == 0 && lYear % 100 != 0 || lYear % 400 == 0)
            {
                Console.WriteLine("This Is LeapYear " + lYear);
            }


            else
            {
                Console.WriteLine("This is not Leap Year" + lYear);
            }
        }
    }
}

