using System;

namespace ScopesExercise
{
    class Program
    { static int W = 1000;//gloval var, and applies in any method
        static void Main(string[] args)
        {
            

        }
        static int Sum(int x, int y)
        {
            
            
            int sum = x + y;
            Console.WriteLine("W=" + W);
            W=W*2;
            Console.WriteLine(x + " , " + y );
            Console.WriteLine ("sum=" + sum);
            return sum;
        }
    }
}
