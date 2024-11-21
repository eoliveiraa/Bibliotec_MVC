
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;


namespace Bibliotec.Contexts
{
    public class Contexts : DbContext
    {
        public Contexts()
        {

        }


        public Contexts(DbContextOptions<Contexts> options) : base(options)
        {

        }

        // OnConfiguring -> possui a configuraçao com o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=NOTE33-S28\\SQLEXPRESS; Initial Catalog =Bibliotec_mvc; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");

            }

        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<LivroCategoria> LivroCategoria { get; set; }
        public DbSet<LivroReserva> LivroReserva { get; set; }
        public DbSet<Usuario> Usuario { get; set; }




    }

}