using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AppBootstrap.Models
{
    public partial class netsenaContext : DbContext
    {
        public netsenaContext()
        {
        }

        public netsenaContext(DbContextOptions<netsenaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySql("server=localhost;userid=root;database=netsena", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.24-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.Property(e => e.Codigo)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("codigo");

                entity.Property(e => e.Correo)
                    .HasMaxLength(30)
                    .HasColumnName("correo")
                    .HasCharSet("utf8");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre")
                     .HasCharSet("utf8");
                
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.id)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.Property(e => e.id)
                  .HasColumnName("id")
                    .HasColumnType("int(10)");


                entity.Property(e => e.nombre)
                       .HasColumnName("nombre")
                      .HasColumnType("varchar(50)")
                      .HasCharSet("utf8");
                      



                entity.Property(e => e.apodo)
                     .HasColumnName("apodo")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8");



                entity.Property(e => e.clave)
                .HasColumnName("clave")
                            .HasColumnType("varchar(10)")
                   .HasCharSet("utf8");

                entity.Property(e => e.Rol)
                .HasColumnName("rol")
                   .HasColumnType("varchar(20)")
                   .HasCharSet("utf8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
