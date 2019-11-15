using System.Data.Entity;
using ProvaBackEnd.Models.Entities;

namespace ProvaBackEnd.Models
{
    public class FaleMaisContext : DbContext
    {
        public FaleMaisContext() 
        : base("FaleMaisContext")
        {
            
        }

        public DbSet<Ligacao> Ligacoes { get; set; }
        public DbSet<Valor> Valores { get; set; }


    }
}