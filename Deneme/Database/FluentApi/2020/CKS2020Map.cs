
using Entity._2020;
using System.Data.Entity.ModelConfiguration;

namespace Deneme.Database.FluentApi._2020
{
    public class CKS2020Map : EntityTypeConfiguration<CKS2020>
    {
        public CKS2020Map()
        {
            this.ToTable("ÇKS 2020 Listesi");

          

      

        }
    }
}
