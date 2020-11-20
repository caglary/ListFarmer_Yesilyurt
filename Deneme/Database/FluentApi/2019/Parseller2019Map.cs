using Entity._2019;
using System.Data.Entity.ModelConfiguration;

namespace Deneme.Database.FluentApi._2019
{
    public class Parseller2019Map:EntityTypeConfiguration<Parseller2019>
    {
        public Parseller2019Map()
        {
            this.ToTable("Parsel Bilgileri 2019");
        }
    }
}
