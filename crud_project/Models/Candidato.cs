namespace crud_project.Models
{
    public class Candidato
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public int Numero {get;set;}
        public string Partido {get;set;}

        public Candidato(){}

        public Candidato(int id, string nome, int numero, string partido){
            this.Id=id;
            this.Nome=nome;
            this.Numero=numero;
            this.Partido=partido;
        }

    }
}