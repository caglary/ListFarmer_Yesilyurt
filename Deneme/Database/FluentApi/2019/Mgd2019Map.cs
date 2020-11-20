using Entity._2019;
using System.Data.Entity.ModelConfiguration;

namespace Deneme.Database.FluentApi._2019
{
    public class Mgd2019Map:EntityTypeConfiguration<Mgd2019>
    {
        public Mgd2019Map()
        {
            this.ToTable("Mazot Gubre Destek 2019");
        }
    }
}
