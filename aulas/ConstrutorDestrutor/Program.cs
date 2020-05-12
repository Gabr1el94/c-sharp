using System;

namespace ConstrutorDestrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Informe o nome do jogador!");
            nome = Console.ReadLine();          
            Jogador jogador = new Jogador(nome,50,true);
            jogador.info();
        }
    }
}
