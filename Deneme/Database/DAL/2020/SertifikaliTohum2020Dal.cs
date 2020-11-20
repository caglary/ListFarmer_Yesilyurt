using Core;
using Deneme.Database.Context;
using Entity;
using Entity._2020;
using System.Collections.Generic;
using System.Linq;
namespace Deneme.Database.DAL._2020
{
    public class SertifikaliTohum2020Dal:IBaseDal<SertifikaliTohum2020>
    {
      

        public List<SertifikaliTohum2020> GetAll()
        {
            using (YesilyurtDbContext db = new YesilyurtDbContext())
            {
                return db.SertifikaliTohum2020Kayitlar.ToList();
            }
        }

        public int Add(SertifikaliTohum2020 Entity)
        {
            using (YesilyurtDbContext db = new YesilyurtDbContext())
            {
                db.SertifikaliTohum2020Kayitlar.Add(Entity);
                db.SaveChanges();
                return 1;
            }
        }

        public int Update(SertifikaliTohum2020 Entity)
        {
            using (YesilyurtDbContext db = new YesilyurtDbContext())
            {
                var result = db.SertifikaliTohum2020Kayitlar.ToList().Where(I => I.Id == Entity.Id).FirstOrDefault();
                if (result != null)
                {
                    result.SertifikaliTohumDosyaNo = Entity.SertifikaliTohumDosyaNo;
                    result.MuracaatTarih = Entity.MuracaatTarih;
                    result.FaturaNo = Entity.FaturaNo;
                    result.FirmaAdi = Entity.FirmaAdi;
                    result.Urun = Entity.Urun;
                    result.UrunCesidi = Entity.UrunCesidi;
                    result.Miktari = Entity.Miktari;
                    result.BirimFiyati = Entity.BirimFiyati;
                    result.ToplamMaliyet = Entity.ToplamMaliyet;
                    result.SertifikaNo = Entity.SertifikaNo;
                    db.SaveChanges();
                    return 1;
                }
                else return 0;
            }
        }

        public int Delete(SertifikaliTohum2020 Entity)
        {
            using (YesilyurtDbContext db = new YesilyurtDbContext())
            {
                var result = db.SertifikaliTohum2020Kayitlar.Find(Entity.Id);
                db.SertifikaliTohum2020Kayitlar.Remove(result);
                return db.SaveChanges();
            }
        }
    }
}
