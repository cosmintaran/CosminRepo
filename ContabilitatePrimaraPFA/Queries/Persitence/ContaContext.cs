namespace Queries.Persitence
{
    using System.Data.Entity;
    using Core.Domain;
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
                .Property(e => e.Scopul_Obiectul_Contractului)
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

            modelBuilder.Entity<Lucrare>()
                .Property(e => e.Avizator_Registrator)
                .IsUnicode(false);

            modelBuilder.Entity<ReceptionatRespins>()
                .HasMany(e => e.Lucrare)
                .WithOptional(e => e.ReceptionatRespins)
                .HasForeignKey(e => e.Receptionat_Respins);
        }
    }
}
