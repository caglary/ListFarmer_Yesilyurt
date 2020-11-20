using Core;
using Deneme.Database.DAL;
using Entity;
using System.Collections.Generic;
using System.Linq;
namespace Deneme.Business
{
    public class CiftcilerBll : IBaseBLL<Ciftci>
    {
        CiftcilerDal dll;
        public CiftcilerBll()
        {
            dll = new CiftcilerDal();
        }
        public List<Ciftci> GetAll()
        {
            return dll.GetAll();
        }
        public Ciftci IsletmeBilgiGetir(string TcNumarasi)
        {

            Selenium _selenium = new Selenium();
           return _selenium.IsletmeBilgiGetir(TcNumarasi);


        }
        public int Add(Ciftci result)
        {
            dll.Add(result);
            return 1;
        }
        public int Update(Ciftci result)
        {
            dll.Update(result);
            return 1;
        }
        public int Delete(Ciftci Entity)
        {
            return 0;
        }

        public void Restore(Ciftci item)
        {
            var ciftciVarlikKontrol = GetAll().Where(I => I.TcKimlikNo == item.TcKimlikNo).SingleOrDefault();
            if (ciftciVarlikKontrol != null)//yani tc numarası bulunursa...
            {
                dll.Update(item);//database içerisindeki kayıt güncellenecek.
            }
            else //tc bulunamadığı durum...
            {
                dll.Add(item);//database içerisine eklenecek.
            }

        }
    }
}
