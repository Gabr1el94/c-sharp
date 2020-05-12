using System;
namespace ConstrutorDestrutor
{
    class Jogador{
        public int energia;
        public bool vivo;

        public string nome;

        public Jogador(string nome,int energia,bool vivo){
            this.energia=energia;
            this.vivo=vivo;
            this.nome=nome;
        }

        public Jogador(string nome){
            this.energia=100;
            this.vivo=true;
            this.nome=nome;
        }

        public Jogador(){
            this.energia=100;
            this.vivo=true;
            this.nome="Gabriel";
        }

        public void info(){
            Console.WriteLine("Nome da Pessoa: {0}",nome);
            Console.WriteLine("Energia do Jogador: {0}",energia);
            Console.WriteLine("Está vivo: {0}",vivo);
        }

        // Destrutor
        // ~Jogador(){
        //     Console.WriteLine("Jogador destruido");
        // }
    }   
}