using System;

namespace Myfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constante
             const double pi = 3.14159;
            //Variavel
            string nome = "Gabriel";

            Console.WriteLine("Hello World!");
            Console.WriteLine("Nome:"+nome+"\n Pi:"+pi);
            //Capturando os dados 'args'
            if (!args[0].Equals("") && !args[0].Equals(null)){
                Console.WriteLine(args[0]);
            }
        }
    }
}
