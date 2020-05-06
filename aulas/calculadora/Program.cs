using System;

namespace calculadora
{
    class Program
    {
        
        static void Main(String[] args){
            int[] numeros = new int[2];
            char escolha;
            string operador;
            
            inicio:
            Console.Clear();
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Informe o seu "+(i+1)+"º valor:");
                numeros[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            
              

            Console.WriteLine("Informe o tipo de operador:");
            Console.Write(" '+' -> Adição \n"
            +" '-'-> Subtração \n "
            +" '*'-> Multiplicação \n "
            +" '/'-> Divisão \n ");
            operador = char.Parse(Console.ReadLine());
            switch (operador)
            {
                case "+":
                    Console.WriteLine("Resultado:"+Extensao.soma(numeros[0],numeros[1]));
                    break;
                case "-":
                    Console.WriteLine("Resultado:"+Extensao.subtracao(numeros[0],numeros[1]));
                    break;
                case "*":
                    Console.WriteLine("Resultado:"+Extensao.multiplicacao(numeros[0],numeros[1]));
                    break;
                case "/":
                    Console.WriteLine("Resultado:"+Extensao.divisao(numeros[0],numeros[1]));
                    break;
                default:
                    Console.WriteLine("Operador não foi encontrado! :(");
                    break;
            }
            Console.Write("Deseja realizar o cálculo novamente?[s/n]:");
            escolha = char.Parse(Console.ReadLine());
            if (escolha=='s' || escolha=='S')
            {
                goto inicio;
            }else{
                Console.Clear();
                Console.WriteLine("Fim do Programa");
            }
        }
    }
}
