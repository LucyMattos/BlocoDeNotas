using Microsoft.EntityFrameworkCore;
using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Data.Context
{
    public partial class NotasContext : DbContext
    {
        public NotasContext()
        {
        }

        public NotasContext(DbContextOptions<NotasContext> options)
            : base(options)
        {
        }


        public virtual DbSet<BlocoDeNota> BlocoDeNotas { get; set; }

        public virtual DbSet<BlocoDeNotasIten> BlocoDeNotasItens { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NotasDB;Trusted_Connection=True;MultipleActiveResultSets=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlocoDeNota>(entity =>
            {
                entity.Property(e => e.Titulo)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlocoDeNotasIten>(entity =>
            {
                entity.Property(e => e.Titulo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBlocoDeNotasNavigation).WithMany(p => p.BlocoDeNotasItens)
                    .HasForeignKey(d => d.IdBlocoDeNotas)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
