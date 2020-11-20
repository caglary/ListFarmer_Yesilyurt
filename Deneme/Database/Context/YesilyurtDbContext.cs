using Deneme.Database.FluentApi;
using Deneme.Database.FluentApi._2019;
using Deneme.Database.FluentApi._2020;
using Entity;
using Entity._2019;
using Entity._2020;
using Entity._2021;
using System.Data.Entity;
namespace Deneme.Database.Context
{
    public class YesilyurtDbContext : DbContext
    {
        public YesilyurtDbContext() : base(DatabaseAdres.ConnectionString())
        {
        }
        public DbSet<Ciftci> CiftciListesi { get; set; }
        public DbSet<CKS2020> Cks2020Kayitlar { get; set; }
        public DbSet<SertifikaliTohum2020> SertifikaliTohum2020Kayitlar { get; set; }
        public DbSet<Mgd2019> MGD2019Kayitlar { get; set; }
        public DbSet<Parseller2019> ParselListesi2019 { get; set; }
        public DbSet<CKS2021> Cks2021Kayıtlar { get; set; }






        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new CiftcilerMap());

            modelBuilder.Configurations.Add(new CKS2020Map());

            modelBuilder.Configurations.Add(new ST2020Map());

            modelBuilder.Configurations.Add(new Mgd2019Map());

            modelBuilder.Configurations.Add(new Parseller2019Map());

            modelBuilder.Configurations.Add(new Cks2021Map());















        }
    }
}
