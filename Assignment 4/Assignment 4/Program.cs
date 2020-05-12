using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            int[][] jagged= new int[4][] { new int[4] { 00, 01, 02, 03 }, new int[4] { 10, 11, 12, 13 }, new int[4] { 20, 21, 22, 23 }, new int[4] { 30, 31, 32, 33 } };
            int[,] multiDim = new int[4, 4] { { 00, 01, 02, 03 }, { 10, 11, 12, 13 }, { 20, 21, 22, 23 }, { 30, 31, 32, 33 } };

            for (int i = 0; i < intArray.Length; i++)
                intArray[i] = i;

            foreach (int io in intArray)
                Console.WriteLine("Foreach: {0}", io);

            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine("For: {0}", i);

            foreach(int i in multiDim)
                Console.WriteLine("Multi-dimensional: {0}", i);

            Iterator(intArray, 0);

            Console.WriteLine("Jagged Array: ");
            foreach (int[] l1 in jagged)
            {
                foreach (int l2 in l1)
                    Console.Write("{0} ", l2.ToString());

                Console.WriteLine();

            }

        }

        static void Iterator(int[] intArray, int index)
        {
            if (index != intArray.Length)
            {
                Console.WriteLine("Recursion: {0}", intArray[index]);

                Iterator(intArray, ++index);

            }

        }

    }

}
