using System;
using Newtonsoft.Json;
using MyCryptographGabs.Models;

namespace MyCryptographGabs
{
    class Program
    {
        const string key = "14441";
        static void Main(string[] args)
        {
            var msgJson = JsonConvert.SerializeObject(
                new Produto{
                    Id = 140,
                    Nome = "Produto Teste!"
                }
            );
            
            var vlrCoded = CryptographGabs.Cryptograph.Security.cryptographer(msgJson,key);

            Console.WriteLine("Dado Criptografado: "+vlrCoded);

            if (!string.IsNullOrWhiteSpace(vlrCoded))
            {
                var ObjProduto = CryptographGabs.Cryptograph.Security.decrypt(vlrCoded,key);
                Console.WriteLine("Dado Descriptografado: "+ObjProduto);
            }

            Console.ReadKey();
        }
        
    }
}
