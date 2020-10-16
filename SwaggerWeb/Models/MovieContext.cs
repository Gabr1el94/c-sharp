using Microsoft.EntityFrameworkCore;


namespace SwaggerWeb.Models
{
    public class MovieContext: DbContext
    {
       public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
               builder.Entity<Movie>().HasKey(m => m.Id);
               base.OnModelCreating(builder);
        }
    }
}