using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Harmonic
    {
        public static void Harmonicfind()
        {
            Console.WriteLine("Enter the a number for harmonic");
            int N = Convert.ToInt32(Console.ReadLine());
            double first = 0.0;

            if (N > 0)
            {

                for (int i = 1; i < N; i++)
                {
                    first = first + (1.0 / i);
                    Console.WriteLine("Harmonic : " + first);
                }
            }
            else
            {
                Console.WriteLine("Please Enter the value greater than 0 ");
            }
        }
    }
}
