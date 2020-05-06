using System;

namespace Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            // << Dobrar o valor 
            // >> Diminui pela métade
            int num=10;
            num=num<<1;
            Console.WriteLine("Dobro : "+num);
            int num2=5>>1;
            Console.WriteLine("Métade : "+num2);
        }
    }
}
