using APLICACAO_FGF.Models;
using Microsoft.EntityFrameworkCore;

namespace APLICACAO_FGF.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options)
            :base(options)
        { }

        public DbSet<Produto> Produto { get; set; }
    }

}
