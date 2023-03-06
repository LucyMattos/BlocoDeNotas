using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NotesAPI.Models;

public partial class NotesContext : DbContext
{
    public NotesContext()
    {
    }

    public NotesContext(DbContextOptions<NotesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Data.Models.Entities.BlocoDeNotas> BlocoDeNotas { get; set; }

    public virtual DbSet<Data.Models.Entities.BlocoDeNotasItens> BlocoDeNotasItens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BlocoDeNotas;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlocoDeNota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BlocoDeN__3214EC077AB31B05");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BlocoDeNotasIten>(entity =>
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
