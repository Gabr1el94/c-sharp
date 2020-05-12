using System;

namespace ArgumentoParams
{
    class Program
    {
        static void Main(string[] args)
        {
            soma(10,4,5);
        }

        static void soma(params int[]n){
            int res=0;
            if (n.Length < 1)
            {
                Console.WriteLine("Não existe valores a serem somados");
            }else if(n.Length < 2){
                Console.WriteLine("Valores insuficientes para soma:{soma}",n[0]);
            }else{
                for (int i = 0; i < n.Length; i++)
                {
                    res+=n[i];              
                }
                Console.WriteLine("A soma dos valores é: {0}",res);
            }
        }

    }
}
