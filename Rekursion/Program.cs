using System.Reflection.Metadata.Ecma335;

namespace Rekursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(40));
            Console.WriteLine(Nac(40));

        }

        public static long Fib(long len) 
        {
            if (len == 1 || len == 2)
            {
                return 1;
            }
            return Fib(len-1) + Fib(len-2);
        }



        public static long Nac(long len)
        {
            var result = 1;
            for (var i = 0; i <= len; i++) 
                result = result * i;
            return result;
        }
        
    }
}
