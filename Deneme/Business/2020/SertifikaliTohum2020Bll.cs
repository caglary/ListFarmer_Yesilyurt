using Core;
using Deneme.Database.DAL;
using Deneme.Database.DAL._2020;
using Entity;
using Entity._2020;
using System.Collections.Generic;
using System.Linq;
namespace Deneme.Business._2020
{
    public class SertifikaliTohum2020Bll : IBaseBLL<SertifikaliTohum2020>
    {
        SertifikaliTohum2020Dal dll;
        public SertifikaliTohum2020Bll()
        {
            dll = new SertifikaliTohum2020Dal();
        }
        public int Add(SertifikaliTohum2020 Entity)
        {
            dll.Add(Entity);
            return 1;
        }
        public int Update(SertifikaliTohum2020 Entity)
        {
            dll.Update(Entity);
            return 1;
        }
        public List<SertifikaliTohum2020> GetAll()
        {
            return dll.GetAll();
        }
        public bool MukerrerKayit(SertifikaliTohum2020 Entity)
        {
            var result = GetAll().Where(I => I.FaturaNo == Entity.FaturaNo).FirstOrDefault();
            if (result==null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public int Delete(SertifikaliTohum2020 Entity)
        {
            return dll.Delete(Entity);
        }
    }
}
