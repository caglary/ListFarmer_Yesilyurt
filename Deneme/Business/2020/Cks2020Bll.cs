using Core;
using Deneme.Database.DAL._2020;
using Entity._2020;
using System.Collections.Generic;
namespace Deneme.Business._2020
{
    public class Cks2020Bll : IBaseBLL<CKS2020>
    {
        Cks2020Dal dll;
        public Cks2020Bll()
        {
            dll = new Cks2020Dal();
        }
        public int Add(CKS2020 isletme)
        {
            dll.Add(isletme);
            return 1;
        }
        public int Delete(CKS2020 Entity)
        {
            return dll.Delete(Entity);
        }
        public List<CKS2020> GetAll()
        {
            return dll.GetAll();
        }
        public int Update(CKS2020 result)
        {
            dll.Update(result);
            return 1;
        }
    }
}
