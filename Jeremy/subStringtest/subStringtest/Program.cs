using System;

namespace subStringtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string BillCode = "GSHJKH2-155225";
            //if (BillCode != null)
            //{
            //    int code = Convert.ToInt32(BillCode.Substring(BillCode.IndexOf('-') + 1));
            //    var bill = BillCode.Substring(0, BillCode.IndexOf('-') + 1);
            //    code += 1;
            //    BillCode = bill + code;
            //    Console.WriteLine(BillCode);
            //}
            //else
            //{
            //    BillCode += "-1";
            //    Console.WriteLine(BillCode);
            //}
            if (!string.IsNullOrEmpty(BillCode.Substring(BillCode.IndexOf('-') + 1)))
            {
                BillCode += "-1";
                Console.WriteLine(BillCode);
            }
            else
            {
                int code = Convert.ToInt32(BillCode.Substring(BillCode.IndexOf('-') + 1));
                var bill = BillCode.Substring(0, BillCode.IndexOf('-') + 1);
                code += 1;
                BillCode = bill + code;
                Console.WriteLine(BillCode);
            }
            string bill1 = BillCode;
            Console.WriteLine(bill1);

            Console.ReadLine();
        }
    }
}
