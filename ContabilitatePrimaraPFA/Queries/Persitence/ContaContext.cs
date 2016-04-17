using Queries.Core.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Queries.Persitence
{
    public class ContaContext : DbContext
    {
        public ContaContext() : base("name=ContaDb")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        public virtual DbSet<AcceptatRespins> AcceptateRespinse { get; set; }
        public virtual DbSet<Beneficiar> Beneficiari { get; set; }
        public virtual DbSet<Chitanta> Chitante { get; set; }
        public virtual DbSet<Contract> Contracte { get; set; }
        public virtual DbSet<Factura> Facturi { get; set; }
        public virtual DbSet<Lucrare> Lucrari { get; set; }
        public virtual DbSet<ReceptionatRespins> ReceptionateRespinse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContaConfiguration());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
