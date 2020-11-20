using Entity._2020;
using System.Data.Entity.ModelConfiguration;

namespace Deneme.Database.FluentApi._2020
{
    public class ST2020Map:EntityTypeConfiguration<SertifikaliTohum2020>
    {
        public ST2020Map()
        {
            this.HasKey(I => I.Id);

            this.ToTable("Sertifikalı Tohum Başvuru 2020");
          

        }
    }
}
