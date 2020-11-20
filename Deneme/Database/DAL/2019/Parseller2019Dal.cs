using Core;
using Deneme.Database.Context;
using Entity._2019;
using System.Collections.Generic;
using System.Linq;
namespace Deneme.Database.DAL._2019
{
    public class Parseller2019Dal:IBaseDal<Parseller2019>
    {
      
        
        List<Parseller2019> IBaseDal<Parseller2019>.GetAll()
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                return context.ParselListesi2019.ToList();
            }
        }

        public int Add(Parseller2019 Entity)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                context.ParselListesi2019.Add(Entity);
                context.SaveChanges();
                return 1;
            }
        }

        public int Update(Parseller2019 Entity)
        {
            return 0;
        }

        public int Delete(Parseller2019 Entity)
        {
            return 0;

        }
    }
}
