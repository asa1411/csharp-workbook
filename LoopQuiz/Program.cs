using System;

namespace LoopQuiz
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] ar = { 10, 2, 3, 4, 50 };
            int biggestOneSoFar = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                int currentNumber = ar[i];
                if (currentNumber > biggestOneSoFar)
                    biggestOneSoFar = currentNumber;

                Console.WriteLine("Iteration #" + i + " =>" + biggestOneSoFar);
            }

        }
    }


}
