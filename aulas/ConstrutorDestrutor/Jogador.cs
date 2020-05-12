using System;
namespace ConstrutorDestrutor
{
    class Jogador{
        public int energia;
        public bool vivo;

        public string nome;

        public Jogador(string nome){
            this.energia=100;
            this.vivo=true;
            this.nome=nome;
        }

        ~Jogador(){
            Console.WriteLine("Jogador destruido");
        }
    }   
}