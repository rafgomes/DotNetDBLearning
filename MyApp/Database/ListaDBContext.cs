using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Database
{
    public class Lista
    {
        [Key]
        public int ListaId { get; protected set; }
        public string? Nome { get;  set; }
        public string? Telefone { get;  set; }
    }

    public class ListaDbContext : DbContext
    {
        public DbSet<Lista>? Lista { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=BancoTeste;Trusted_Connection=True;TrustServerCertificate=true");
           // optionsBuilder.LogTo(Console.WriteLine);           


        }

    }    
}