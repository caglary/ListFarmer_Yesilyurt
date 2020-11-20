using Core;
using Deneme.Database.DAL._2019;
using Entity._2019;
using System.Collections.Generic;
namespace Deneme.Business._2019
{
    public class Mgd2019Bll : IBaseBLL<Mgd2019>
    {
        Mgd2019Dal MGDDal;
        public Mgd2019Bll()
        {
            MGDDal = new Mgd2019Dal();
        }
        public int Add(Mgd2019 Entity)
        {
            return 1;
        }
        public int Delete(Mgd2019 Entity)
        {
            return 1;
        }
        public List<Mgd2019> GetAll()
        {
            return MGDDal.GetAll();
        }
        public int Update(Mgd2019 Entity)
        {
            return 1;
        }
    }
}
