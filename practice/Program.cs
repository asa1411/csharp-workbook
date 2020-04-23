using System;

namespace practice
{
    class Program
    {
        static void Main(string[] num)

        {
            Console.WriteLine(divisible(num));

        }

        static int divisible(string[] args)
        {
            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    num = num + 1;
            }
            return (num);
        }


    }
}
