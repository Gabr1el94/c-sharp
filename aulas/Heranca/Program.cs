using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapidão","Vermelho");
            Console.WriteLine("Nome......:{0}",c1.nome);
            Console.WriteLine("Cor......:{0}",c1.cor);
            Console.WriteLine("Rodas......:{0}",c1.getRodas());
            Console.WriteLine("Vel.Maxima......:{0}",c1.velMax);
            Console.WriteLine("Vel.Maxima......:{0}",c1.getLigado());

        }
    }
}
