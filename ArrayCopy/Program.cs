using System;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array");
            int numbElem = Convert.ToInt32(Console.ReadLine());
            int[] firstArr = new int[100];
            int[] secArr = new int[firstArr.Length];

            Console.WriteLine("Add an element");
            for (int i = 0; i < numbElem; i++)
            {
                firstArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Element {0} : {1}", i, firstArr[i]);
            }

            Console.WriteLine("The elements stored in the first array are :");
            for (int i = 0; i < numbElem; i++)
            {
                Console.Write("{0} ", firstArr[i]);
            }
            //Copy elements of first array into second array.
            for (int i = 0; i < numbElem; i++)
            {
                firstArr[i] = secArr[i];
            }

            Console.WriteLine("The elements stored in the second array are :");
            for (int i = 0; i < numbElem; i++)
            {
                Console.Write("{0} ", secArr[i]);
            }
            Console.Read();
        }
    }
}
