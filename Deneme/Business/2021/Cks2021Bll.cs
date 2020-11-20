using Core;
using Deneme.Database.DAL._2021;
using Entity._2021;
using System.Collections.Generic;

namespace Deneme.Business._2021
{
    public class Cks2021Bll : IBaseBLL<CKS2021>
    {
        Cks2021Dal dll;
        public Cks2021Bll()
        {
            dll = new Cks2021Dal();
        }
        public int Add(CKS2021 Entity)
        {
            dll.Add(Entity);
            return 1;
        }

        public int Delete(CKS2021 Entity)
        {
            return dll.Delete(Entity);
        }

        public List<CKS2021> GetAll()
        {
            return dll.GetAll();
        }

        public int Update(CKS2021 Entity)
        {
            dll.Update(Entity);
            return 1;
        }
    }
}
