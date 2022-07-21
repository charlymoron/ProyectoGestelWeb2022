using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;




namespace Dominio.Model
{
    public partial class GestelWeb2014Context : DbContext
    {
        public GestelWeb2014Context()
        {
        }

        public GestelWeb2014Context(DbContextOptions<GestelWeb2014Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ArchivosImportado> ArchivosImportados { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<DetalleEstadistica> DetalleEstadisticas { get; set; } = null!;
        public virtual DbSet<DetalleEstadisticaPorEnlace> DetalleEstadisticaPorEnlaces { get; set; } = null!;
        public virtual DbSet<Dominio> Dominios { get; set; } = null!;
        public virtual DbSet<Edificio> Edificios { get; set; } = null!;
        public virtual DbSet<Enlace> Enlaces { get; set; } = null!;
        public virtual DbSet<Estadistica> Estadisticas { get; set; } = null!;
        public virtual DbSet<Evento> Eventos { get; set; } = null!;
        public virtual DbSet<IdentificadorObjeto> IdentificadorObjetos { get; set; } = null!;
        public virtual DbSet<Mantenedor> Mantenedors { get; set; } = null!;
        public virtual DbSet<Objeto> Objetos { get; set; } = null!;
        public virtual DbSet<OperadorRegistro> OperadorRegistros { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Provincium> Provincia { get; set; } = null!;
        public virtual DbSet<TipoEstadistica> TipoEstadisticas { get; set; } = null!;
        public virtual DbSet<TipoEvento> TipoEventos { get; set; } = null!;
        public virtual DbSet<TipoIdentificador> TipoIdentificadors { get; set; } = null!;
        public virtual DbSet<TipoObjeto> TipoObjetos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               // optionsBuilder.UseSqlServer("Server=localhost; Database=GestelWeb2014; User Id=sa; Password=P@ssword2710");

                string connectionString = ConfigurationManager.AppSettings["GestelWeb2014"]!;

                optionsBuilder.UseSqlServer(connectionString);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<ArchivosImportado>(entity =>
            {
                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Operador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operador");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ArchivosImportados)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cliente_ArchivosImportados");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Activo).HasComment("Activo = 1 Inactivo = 0");

                entity.Property(e => e.FechaDeAlta).HasColumnType("date");

                entity.Property(e => e.FechaDeBaja).HasColumnType("date");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleEstadistica>(entity =>
            {
                entity.ToTable("DetalleEstadistica");

                entity.HasIndex(e => e.EnlaceId, "IdxEnlaceId");

                entity.HasIndex(e => new { e.ObjetoId, e.EnlaceId }, "IdxEnlaceIdObjetoId");

                entity.HasIndex(e => new { e.EstadisticaId, e.ObjetoId, e.EnlaceId }, "IdxEstadisticaEnlaceObjeto");

                entity.HasIndex(e => e.EstadisticaId, "IdxEstadisticaId");

                entity.HasIndex(e => e.ObjetoId, "IdxObjetoId");

                entity.Property(e => e.PorcentajeDisponibilidad).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.PorcentajeDisponibilidadConRespaldo).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Tdf)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("TDF");

                entity.Property(e => e.Tdfneto)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("TDFNeto");

                entity.Property(e => e.TiempoMuerto).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.TiempoMuertoConRespaldo).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.TiempoMuertoDelRespaldo).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.TiempoMuertoEntreFallas).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Tmef)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("TMEF");

                entity.Property(e => e.Tmr)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("TMR");

                entity.HasOne(d => d.Estadistica)
                    .WithMany(p => p.DetalleEstadisticas)
                    .HasForeignKey(d => d.EstadisticaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Estadistica_DetalleEstadistica");

                entity.HasOne(d => d.Objeto)
                    .WithMany(p => p.DetalleEstadisticas)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Objeto_DetalleEstadistica");
            });

            modelBuilder.Entity<DetalleEstadisticaPorEnlace>(entity =>
            {
                entity.ToTable("DetalleEstadisticaPorEnlace");

                entity.HasIndex(e => e.EnlaceId, "IdxEnlaceId");

                entity.HasIndex(e => new { e.EstadisticaId, e.EnlaceId }, "IdxEstadisticaEnlace");

                entity.HasIndex(e => e.EstadisticaId, "IdxEstadisticaId");

                entity.Property(e => e.Disponibilidad).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.DisponibilidadConRespaldo).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Tdf)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("TDF");

                entity.Property(e => e.TdfconRespaldo)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("TDFConRespaldo");

                entity.Property(e => e.Tmef)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("TMEF");

                entity.HasOne(d => d.Enlace)
                    .WithMany(p => p.DetalleEstadisticaPorEnlaces)
                    .HasForeignKey(d => d.EnlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Enlace_DetalleEstadisticaPorEnlace");

                entity.HasOne(d => d.Estadistica)
                    .WithMany(p => p.DetalleEstadisticaPorEnlaces)
                    .HasForeignKey(d => d.EstadisticaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Estadistica_DetalleEstadisticaPorEnlace");
            });

            modelBuilder.Entity<Dominio>(entity =>
            {
                entity.ToTable("Dominio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Edificio>(entity =>
            {
                entity.ToTable("Edificio");

                entity.HasIndex(e => e.ClienteId, "IdxClienteId");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Edificios)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("Cliente_Edificio");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Edificios)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Provincia_Edificio");
            });

            modelBuilder.Entity<Enlace>(entity =>
            {
                entity.ToTable("Enlace");

                entity.HasIndex(e => e.EdificioId, "IdxEdificio");

                entity.Property(e => e.EsDeTerceros).HasDefaultValueSql("((0))");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Edificio)
                    .WithMany(p => p.Enlaces)
                    .HasForeignKey(d => d.EdificioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Edificio_Enlace");

                entity.HasMany(d => d.Dominios)
                    .WithMany(p => p.Enlaces)
                    .UsingEntity<Dictionary<string, object>>(
                        "EnlaceDominio",
                        l => l.HasOne<Dominio>().WithMany().HasForeignKey("DominioId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Dominio_EnlaceDominio"),
                        r => r.HasOne<Enlace>().WithMany().HasForeignKey("EnlaceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Enlace_EnlaceDominio"),
                        j =>
                        {
                            j.HasKey("EnlaceId", "DominioId");

                            j.ToTable("EnlaceDominio");
                        });
            });

            modelBuilder.Entity<Estadistica>(entity =>
            {
                entity.ToTable("Estadistica");

                entity.Property(e => e.Desde).HasColumnType("datetime");

                entity.Property(e => e.DuracionExcluida)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("duracionExcluida");

                entity.Property(e => e.Hasta).HasColumnType("datetime");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Estadisticas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cliente_Estadistica");

                entity.HasOne(d => d.Dominio)
                    .WithMany(p => p.Estadisticas)
                    .HasForeignKey(d => d.DominioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dominio_Estadistica");

                entity.HasOne(d => d.TipoEstadistica)
                    .WithMany(p => p.Estadisticas)
                    .HasForeignKey(d => d.TipoEstadisticaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TipoEstadistica_Estadistica");
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.ToTable("Evento");

                entity.HasIndex(e => e.Fecha, "Idx_Fecha");

                entity.HasIndex(e => new { e.Fecha, e.TipoEvento, e.ObjetoId }, "Idx_fecha_tipo_objeto");

                entity.HasIndex(e => e.ObjetoId, "Idx_objeto");

                entity.HasIndex(e => new { e.ObjetoId, e.TipoEvento, e.Fecha }, "idxEventoUnico")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Objeto)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Objeto_Evento");

                entity.HasOne(d => d.OperadorRegistro)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.OperadorRegistroId)
                    .HasConstraintName("OperadorRegistro_CierreEvento");

                entity.HasOne(d => d.TipoEventoNavigation)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.TipoEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TipoEvento_Evento");
            });

            modelBuilder.Entity<IdentificadorObjeto>(entity =>
            {
                entity.ToTable("IdentificadorObjeto");

                entity.Property(e => e.ValorIdentificador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Objeto)
                    .WithMany(p => p.IdentificadorObjetos)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Objeto_IdentificadorObjeto");

                entity.HasOne(d => d.TipoIdentificador)
                    .WithMany(p => p.IdentificadorObjetos)
                    .HasForeignKey(d => d.TipoIdentificadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TipoIdentificador_IdentificadorObjeto");
            });

            modelBuilder.Entity<Mantenedor>(entity =>
            {
                entity.ToTable("Mantenedor");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Objeto>(entity =>
            {
                entity.ToTable("Objeto");

                entity.HasIndex(e => e.EnlaceId, "IdxEnlaceID");

                entity.HasIndex(e => e.ProveedorId, "IdxProveedor");

                entity.HasIndex(e => new { e.EnlaceId, e.ProveedorId }, "IdxProveedorEnlace");

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Enlace)
                    .WithMany(p => p.Objetos)
                    .HasForeignKey(d => d.EnlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Enlace_Objeto");

                entity.HasOne(d => d.Mantenedor)
                    .WithMany(p => p.Objetos)
                    .HasForeignKey(d => d.MantenedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Mantenedor_Objeto");

                entity.HasOne(d => d.ObjetoBackup)
                    .WithMany(p => p.InverseObjetoBackup)
                    .HasForeignKey(d => d.ObjetoBackupId)
                    .HasConstraintName("Objeto_Objeto");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Objetos)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Proveedor_Objeto");

                entity.HasOne(d => d.TipoObjeto)
                    .WithMany(p => p.Objetos)
                    .HasForeignKey(d => d.TipoObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TipoObjeto_Objeto");
            });

            modelBuilder.Entity<OperadorRegistro>(entity =>
            {
                entity.ToTable("OperadorRegistro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("Proveedor");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoEstadistica>(entity =>
            {
                entity.ToTable("TipoEstadistica");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.TipoEstadisticas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cliente_TipoEstadistica");
            });

            modelBuilder.Entity<TipoEvento>(entity =>
            {
                entity.ToTable("TipoEvento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoIdentificador>(entity =>
            {
                entity.ToTable("TipoIdentificador");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoObjeto>(entity =>
            {
                entity.ToTable("TipoObjeto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
