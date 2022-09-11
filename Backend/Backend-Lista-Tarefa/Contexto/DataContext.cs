using Backend_Lista_Tarefa.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Backend_Lista_Tarefa.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Tarefa> Tarefa { get; set; }
    }
}
