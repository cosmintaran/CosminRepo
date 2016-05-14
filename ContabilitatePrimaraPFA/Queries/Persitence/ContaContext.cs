using System.Data.Entity;
using Queries.Core.Domain;

namespace Queries.Persitence
{
    public partial class ContaContext : DbContext
    {
        public ContaContext()
            : base("name=ContaContext")
        {
        }

        public virtual DbSet<AcceptataRefuzata> AcceptataRefuzata { get; set; }
        public virtual DbSet<Beneficiar> Beneficiar { get; set; }
        public virtual DbSet<Chitanta> Chitanta { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Judet> Judet { get; set; }
        public virtual DbSet<Lucrare> Lucrare { get; set; }
        public virtual DbSet<ReceptionatRespins> ReceptionatRespins { get; set; }
        public virtual DbSet<TipAct> TipAct { get; set; }
        public virtual DbSet<TipLucrare> TipLucrare { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcceptataRefuzata>()
                .HasMany(e => e.Lucrare)
                .WithRequired(e => e.AcceptataRefuzata)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Beneficiar>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.ObiectulContractului)
                .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Suma)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Observatii)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Suma)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Factura>()
                .HasMany(e => e.Chitanta)
                .WithRequired(e => e.Factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lucrare>()
                .Property(e => e.AvizatorRegistrator)
                .IsUnicode(false);

            modelBuilder.Entity<Lucrare>()
                .Property(e => e.CadTop)
                .IsUnicode(false);

            modelBuilder.Entity<Lucrare>()
                .Property(e => e.Observatii)
                .IsUnicode(false);

            modelBuilder.Entity<ReceptionatRespins>()
                .HasMany(e => e.Lucrare)
                .WithRequired(e => e.ReceptionatRespins)
                .WillCascadeOnDelete(false);
        }
    }
}
