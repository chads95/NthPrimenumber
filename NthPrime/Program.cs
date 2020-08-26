using System;

namespace NthPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthPrime(15));
        }

        public static bool CheckPrime(int number)
        {
            for (var i = 2; i < number; i++)
            {
                float divided = (float)number / i;

                if(divided % 1 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static int NthPrime(int prime)
        {
            byte conuter = 0;
            for(var i =0; i <= 100; i++)
            {
                if(CheckPrime(i))
                {
                    conuter++;
                }

                if(conuter == prime)
                {
                    return (i);
                }
            }
            return 0;
        }
    }
}
