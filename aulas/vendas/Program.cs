using System;
using System.Globalization;
namespace vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro=0.1;
            string produto = "Pastel";

            valorVenda = valorCompra+(valorCompra*lucro);

            Console.WriteLine("Produto:{0,15}",produto);
            Console.WriteLine("Vlr.Compra:{0,15:c}",valorCompra);
            Console.WriteLine("Lucro:{0,15:p}",lucro.ToString("P",CultureInfo.InvariantCulture));
            Console.WriteLine("Val.Venda:{0,15:c}",valorVenda);
        }
    }
}
