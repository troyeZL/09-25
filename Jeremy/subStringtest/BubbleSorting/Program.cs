using System;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序
            int[] array = { 1, 9, 0, 3, 5, 6 };
            int temp = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine($"冒泡排序");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.ReadLine();
        }
    }
}
