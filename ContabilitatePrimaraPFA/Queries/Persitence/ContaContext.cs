using System;
using System.Data.Entity;
using System.IO;
using Queries.Core.Domain;

namespace Queries.Persitence
{
    public partial class ContaContext : DbContext
    {
        public ContaContext()
            : base("name=ContaContext")
        {
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+@"\ContaPFA");
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        }

        public virtual DbSet<AcceptataRefuzata> AcceptataRefuzata { get; set; }
        public virtual DbSet<Beneficiar> Beneficiar { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Lucrare> Lucrare { get; set; }
        public virtual DbSet<ReceptionatRespins> ReceptionatRespins { get; set; }
        public virtual DbSet<TipAct> TipAct { get; set; }
        public virtual DbSet<TipLucrare> TipLucrare { get; set; }
        public virtual DbSet<Plata> Plata { get; set; }
        public virtual DbSet<Incasare> Incasare {get; set; }

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
