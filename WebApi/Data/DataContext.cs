using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id_cliente = 1, Name = "jadson", Cpf = 1234, Telefone = 8898808, Email = "jadson@gmail.com", Senha = "123" },
                new Cliente { Id_cliente = 2, Name = "jad", Cpf = 4321, Telefone = 8899908, Email = "jadson1@gmail.com", Senha = "321" }
            );
        }
    }
}
