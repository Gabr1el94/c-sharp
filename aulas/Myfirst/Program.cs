using System;

namespace Myfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Capturando os dados 'args'
            if (!args[0].Equals("") && !args[0].Equals(null)){
                Console.WriteLine(args[0]);
            }
        }
    }
}
