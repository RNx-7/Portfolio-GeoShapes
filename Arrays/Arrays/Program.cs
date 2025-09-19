using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;
using System.Timers;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            int[] array2 = {1, 2, 3, 4 };
            string[] array3 = { "Hello",  "World." };
        
            Console.WriteLine(array3[1]);
            int i = Counter(array2);
            Console.WriteLine(i);
            int f = Grösste(array2);
            Console.WriteLine(f);
        }
        // aW
        static int Counter(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum =+ element;
            }
            return (sum / array.Length);
        }

        // kW

        static int Kleinste(int[] array)
        {
            int k = array[0];
            foreach (int element in array)
            {
                if (element < k)
                {
                    k = element;
                }
            }
            return k;
        }

        static int Grösste(int[] array)
        {
            int g = array[0];
            foreach (int element in array)
            {
                if (element > g)
                {
                    g = element;
                }
            }
            return g;
        }
    }
}
