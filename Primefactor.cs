using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Primefactor
    {
        public static void CheckPrime()
        {
            Console.WriteLine("Enter a value to check prime or not");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N);

            int i;
            int a = 0;
            for (i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    a++;
                }

            }
            if (a == 2)
            {
                Console.WriteLine("Prime Number");
                int fact = 1;
                int factor;
                for (i = 2; i <= N; i++)
                {
                    factor = fact * i; //fact = fact * i
                    Console.Write(factor);


                }
            }
            else
            {
                Console.WriteLine("Not prime number");
            }



        }
    }
}
