using Microsoft.EntityFrameworkCore;
using NotesAPI.Business.models.Entities;

namespace NotesAPI.Data.Context
{
    public class BlocoDeNotasContext : DbContext
    {
         
        public BlocoDeNotasContext(DbContextOptions<BlocoDeNotasContext> options) : base(options) { }

        public DbSet<BlocoDeNotas> BlocoDeNotas { get; set; }
        public DbSet<BlocoDeNotasItens> BlocoDeNotasItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
      
    
    }
}
