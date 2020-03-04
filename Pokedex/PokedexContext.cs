using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pokedex
{
    public partial class PokedexContext : DbContext
    {
        public PokedexContext()
        {
        }

        public PokedexContext(DbContextOptions<PokedexContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pokemon> Pokemon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog = Pokedex; Persist Security Info = True; User ID = SA; Password = Passw0rd2018");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.Property(e => e.Pdescription)
                    .HasColumnName("PDescription")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pheight)
                    .HasColumnName("PHeight")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("PName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ptype)
                    .HasColumnName("PType")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pweight)
                    .HasColumnName("PWeight")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
