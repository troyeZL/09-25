using System;

namespace ExchangeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //在不使用第三方的情况下，互换值
            int a = 10;
            int b = 15;
             a = a + b;
             b = a - b;
             a = a - b;
            Console.WriteLine("a === b");
            Console.WriteLine(a + "===" + b);
            Console.ReadLine();
        }
    }
}
