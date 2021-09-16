using System;

namespace Nesteddemo
{
    class Student
    {
        class Program
        {
            static void Main(string[] args)
            {
                int num, i, j, t;
                Console.WriteLine("Enter The Number ");
                num = Convert.ToInt32(Console.ReadLine());
                // simple logic
                for (i = 1; i <= 10; i++)
                {
                    t = num * i;
                    Console.WriteLine("{0} * {1} = {2}", num, i, t);
                }
                // four consecutive number 3 tables
                Console.WriteLine();
                Console.WriteLine("Enter The Number for consecutive table ");
                num = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= 10; i++)
                {
                    for (j = num; j <= num + 3; j++)

                    {
                        t = j * i;
                        Console.Write("{0} * {1} = {2} \t", j, i, t);
                    }
                    Console.WriteLine();

                }
                int k;
                //arrays in reverse order

                Console.WriteLine("Array in reverse order");
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                for (k = arr.Length - 1; k >= 0; k--)
                {
                    Console.WriteLine(arr[i]);
                }
            }


        }
    }
}
