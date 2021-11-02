using System;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            string sentance = "Hello";
            Console.WriteLine(Sum(array, 0));
            Console.WriteLine(Reverse(sentance, sentance.Length - 1));
        }

        static int Sum(int[] array, int index)
        {
            if(array.Length == index)
            {
                return 0;
            }

            return array[index] + Sum(array, index + 1);
        }

        static string Reverse(string sentance, int index)
        {
            if(-1 == index)
            {
                return "";
            }

            return sentance[index] + Reverse(sentance, index -1);
        }
    }
}
