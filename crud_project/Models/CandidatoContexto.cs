using Microsoft.EntityFrameworkCore;

namespace crud_project.Models
{
    public class CandidatoContexto:DbContext
    {

        public CandidatoContexto(DbContextOptions<CandidatoContexto> options): base(options){

        }

        public DbSet<Candidato> Candidato { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder){

           modelBuilder.Entity<Candidato>().HasData(
               new Candidato(1,"Ciro Gomes",51,"PDT"),
               new Candidato(2,"Jair Bolsonaro",17,"PSL"),
               new Candidato(3,"João Amoedo",30,"NOVO"),
               new Candidato(4,"Fernando Haddad",13,"PT"),
               new Candidato(4,"Marina Silva",18,"REDE")
           );

        }

    }
    
}