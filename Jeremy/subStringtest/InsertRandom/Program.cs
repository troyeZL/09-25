using System;
using System.Collections.Generic;

namespace InsertRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生一个int数组，长度为100，并向其随机插入1-100，不能重复
            List<int> list = new List<int>();
            Random r = new Random();
            while (true)
            {
                int temp = r.Next(1, 101);
                if (list.Count == 100) break;
                if (!list.Contains(temp)) list.Add(temp);
            }
            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
            Console.ReadLine();
        }
    }
}
