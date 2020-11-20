using Core;
using Deneme.Database.Context;
using Entity._2019;
using System.Collections.Generic;
using System.Linq;
namespace Deneme.Database.DAL._2019
{
    public class Mgd2019Dal : IBaseDal<Mgd2019>
    {


        public int Add(Mgd2019 Entity)
        {
            return 0;

        }



        public int Delete(Mgd2019 Entity)
        {
            return 0;

        }

        public List<Mgd2019> GetAll()
        {
            using (YesilyurtDbContext db = new YesilyurtDbContext())
            {
                return db.MGD2019Kayitlar.ToList();
            }
        }




        public int Update(Mgd2019 Entity)
        {
            return 0;
        }
    }
}
