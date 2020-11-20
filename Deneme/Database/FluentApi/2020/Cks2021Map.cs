using Entity._2021;
using System.Data.Entity.ModelConfiguration;

namespace Deneme.Database.FluentApi._2020
{
    public class Cks2021Map: EntityTypeConfiguration<CKS2021>
    {
        public Cks2021Map()
        {
            this.ToTable("ÇKS 2021 Listesi");
        }
    }
}
