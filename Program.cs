using System;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "3";
            String b = "2";
            String c = "8";

            String combinacion1 = a + a + c + b;
            String combinacion2 = b + c + a;
            String combinacion3 = b + c + b + c;

            String msg1 = "aacb: " + combinacion1;
            String msg2 = "bca: " + combinacion2;
            String msg3 = "bcbc: " + combinacion3;

            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            Console.WriteLine(msg3);
        }
    }
}
