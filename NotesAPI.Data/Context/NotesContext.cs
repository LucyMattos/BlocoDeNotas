using Microsoft.EntityFrameworkCore;
using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Data.Context
{
    public partial class NotesContext : DbContext
    {
        public NotesContext()
        {
        }

        public NotesContext(DbContextOptions<NotesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlocoDeNotas> BlocoDeNotas { get; set; }

        public virtual DbSet<BlocoDeNotasItens> BlocoDeNotasItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlocoDeNotas>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__BlocoDeN__3214EC077AB31B05");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlocoDeNotasItens>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__BlocoDeN__3214EC07D9418F47");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Descricao)
                    .HasMaxLength(600)
                    .IsUnicode(false);
                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
