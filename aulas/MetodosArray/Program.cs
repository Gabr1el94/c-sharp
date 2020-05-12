using System;

namespace MetodosArray
{
    class Program
    {
        static void Main(string[] args)
        {
           //arrays 
            int[] vetor1= new int[5];
            int[] vetor2= new int[5];
            int[] vetor3= new int[5];
            int[,] matriz= new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};
           //Random
           Console.WriteLine("Random");
           Random random = new Random();
           for (int i = 0; i < vetor.Length; i++)
           {
                vetor1[i] = random.Next(50);
           }

            foreach (var number in vetor1)
            {
                Console.WriteLine(number);
            }
            
             Console.WriteLine("-----------------------------------------");

            // BinarySearch(array,valor); -1 'não foi encontrado'
            Console.WriteLine("BinarySearch");
            int v = 22;
            int pos = Array.BinarySearch(vetor1,v);
            Console.WriteLine("Valor {0} está na posição {1}",v,pos);
            Console.WriteLine("-----------------------------------------");

            // Copy(Ar_origrm,Ar_destino,qtd_elementos)
            Console.WriteLine("Copy");
            Array.Copy(vetor1,vetor2,vetor1.Length);
            foreach (var number in vetor2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-----------------------------------------");

            // CopyTo(Ar_origrm,Ar_destino,qtd_elementos)
            Console.WriteLine("CopyTo");
            vetor1.Copy(vetor3,0);
            foreach (var number in vetor3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("GetLowerBound");
            int MenorIndiceVetor = vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
            Console.WriteLine("Menor Índice do vetor1 {0}",MenorIndiceVetor);

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("GetUpperBound");
            int MenorIndiceVetor = vetor1.GetUpperBound(0);
            int MenorIndiceMatriz_D1 = matriz.GetUpperBound(1);
            Console.WriteLine("Maior Índice do vetor1 {0}",MenorIndiceVetor);

            Console.WriteLine("-----------------------------------------");

            // GetValue(long indice)
            Console.WriteLine("GetValue");
            int valor0=Convert.ToInt32(vetor1.GetValue(3));
            int valor1=Convert.ToInt32(matriz.GetValue(1,3));
            Console.WriteLine("Valor da posição 3 do vetor1: {0}",valor0);

            Console.WriteLine("-----------------------------------------");

            //IndexOf(array,valor)
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1,3);
            Console.WriteLine("Índice do primeiro valor 3: {0}",indice1);
            Console.WriteLine("-----------------------------------------");

            //LastIndexOf(array,valor)
            Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(vetor1,3);
            Console.WriteLine("Indice do último valor 33: {0}",indice2);
            Console.WriteLine("-----------------------------------------");

            //Reverse ex - [1,2,3] = [3,2,1]
            Console.WriteLine("Reverse");
            Array.Reverse(vetor1);
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("-----------------------------------------");

            //SetValue(object valor)
            Console.WriteLine("SetValue");
            vetor2.SetValue(99,0);
            for (int i = 0; i < vetor2.length; i++)
            {
               vetor2.SetValue[0,i]; 
            }

            Console.WriteLine("Vetor 2");
            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("-----------------------------------------");
            //Sort(arrat)
            Console.WriteLine("Sort");
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            
            Console.WriteLine("Vetor 1");
            foreach (var item in vetor1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nVetor 2");
            foreach (var item in vetor2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nVetor 3");
            foreach (var item in vetor3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
