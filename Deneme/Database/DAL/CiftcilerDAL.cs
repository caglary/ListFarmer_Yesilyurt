using Core;
using Deneme.Database.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Deneme.Database.DAL
{
    public class CiftcilerDal:IBaseDal<Ciftci>
    {
        public List<Ciftci> GetAll()
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                return context.CiftciListesi.ToList();
            }
        }
        public int Add(Ciftci entity)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var result = from i in GetAll()
                             where i.TcKimlikNo == entity.TcKimlikNo
                             select i;
                int s = result.Count();
                if (result.Count() == 0)
                {
                    context.CiftciListesi.Add(entity);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    throw new Exception("Aynı Tc Numarası ile kayıt mevcut...");
                }
            }
        }
        public int Update(Ciftci isletme)
        {
            using (YesilyurtDbContext context = new YesilyurtDbContext())
            {
                var result = context.CiftciListesi.ToList().Where(I => I.TcKimlikNo == isletme.TcKimlikNo).FirstOrDefault();
                if (result != null)
                {
                    result.TcKimlikNo = isletme.TcKimlikNo;
                    result.AnneAdi = isletme.AnneAdi;
                    result.BabaAdi = isletme.BabaAdi;
                    result.CepTelefon = isletme.CepTelefon;
                    result.Cinsiyet = isletme.Cinsiyet;
                    result.DogumTarihi = isletme.DogumTarihi;
                    result.Email = isletme.Email;
                    result.EvTelefon = isletme.EvTelefon;
                    result.Il = isletme.Il;
                    result.Ilce = isletme.Ilce;
                    result.KoyMahalle = isletme.KoyMahalle;
                    result.MedeniDurum = isletme.MedeniDurum;
                    result.Ad = isletme.Ad;
                    result.OlumTarihi = isletme.OlumTarihi;
                    result.Soyad = isletme.Soyad;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    throw new Exception("Aranan isletme listede bulunamadı...");
                }
            }
        }
        public int Delete(Ciftci Entity)
        {
            return 0;
        }
    }
}
