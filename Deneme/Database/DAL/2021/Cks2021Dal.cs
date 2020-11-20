using Core;
using Deneme.Database.Context;
using Entity._2021;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deneme.Database.DAL._2021
{
    public class Cks2021Dal : IBaseDal<CKS2021>
    {
        public int Add(CKS2021 Entity)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var result = context.Cks2021Kayıtlar.ToList().Where(I => I.TcKimlikNo == Entity.TcKimlikNo).FirstOrDefault();
                if (result == null)
                {
                    context.Cks2021Kayıtlar.Add(Entity);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    throw new Exception("Aynı Tc numaralı kayıt mevcut...");
                }

            }
        }

        public int Delete(CKS2021 Entity)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var result = context.Cks2021Kayıtlar.ToList().Find(I => I.Id == Entity.Id);
                context.Cks2021Kayıtlar.Remove(Entity);
                return context.SaveChanges();
            }
        }

        public List<CKS2021> GetAll()
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                return context.Cks2021Kayıtlar.ToList();
            }
        }

        public int Update(CKS2021 Entity)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var ciftci = context.Cks2021Kayıtlar.ToList().Where(I => I.TcKimlikNo == Entity.TcKimlikNo).FirstOrDefault();
                if (ciftci != null)
                {
                    ciftci.DosyaNo = Entity.DosyaNo;
                    ciftci.KoyMahalle = Entity.KoyMahalle;
                    ciftci.KayitTarih = Entity.KayitTarih;
                    ciftci.CepTelefon = Entity.CepTelefon;
                    ciftci.EvTelefon = Entity.EvTelefon;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    throw new Exception("Güncelleme işlemi başarısız.");
                }
            }
        }
    }
}
