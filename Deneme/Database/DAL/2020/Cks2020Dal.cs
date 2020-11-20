using Core;
using Deneme.Database.Context;
using Entity._2020;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Deneme.Database.DAL._2020
{
    public class Cks2020Dal : IBaseDal<CKS2020>
    {

        public List<CKS2020> GetAll()
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                return context.Cks2020Kayitlar.ToList();
            }
        }
        public int Add(CKS2020 isletme)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var result = context.Cks2020Kayitlar.ToList().Where(I => I.TcKimlikNo == isletme.TcKimlikNo).FirstOrDefault();
                if (result == null)
                {
                    context.Cks2020Kayitlar.Add(isletme);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    throw new Exception("Aynı Tc numaralı kayıt mevcut...");
                }

            }
        }
        public int Update(CKS2020 result)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var ciftci = context.Cks2020Kayitlar.ToList().Where(I => I.TcKimlikNo == result.TcKimlikNo).FirstOrDefault();
                if (ciftci != null)
                {
                    ciftci.DosyaNo = result.DosyaNo;
                    ciftci.KoyMahalle = result.KoyMahalle;
                    ciftci.KayitTarih = result.KayitTarih;
                    ciftci.CepTelefon = result.CepTelefon;
                    ciftci.EvTelefon = result.EvTelefon;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    throw new Exception("Güncelleme işlemi başarısız.");
                }
            }
        }
        public int Delete(CKS2020 Entity)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var result = context.Cks2020Kayitlar.ToList().Find(I => I.Id == Entity.Id);
                context.Cks2020Kayitlar.Remove(result);
                return context.SaveChanges();
            }
        }
    }
}
