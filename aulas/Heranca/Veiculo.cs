using System;

namespace Heranca
{
    class Veiculo
    {
        private int rodas;
        public int velMax;
        private bool ligado;

        public void ligar(){
            ligado=true;
        }

        public Veiculo(int rodas){
            this.rodas=rodas;
        }

        public void desligado(){
            ligado=false;
        }

        public string getLigado(){
            return (ligado ? "sim" :"não");
        }

        public int getRodas(){
            return rodas;
        }

    }

    class Carro: Veiculo{
        public string nome;
        public string cor;

        public Carro(string nome, string cor):base(4){
            ligar();
            velMax=120;
            this.nome=nome;
            this.cor=cor;
        }
    }
}