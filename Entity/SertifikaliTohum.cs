using Core.Entity;
using System;
using System.Collections.Generic;

namespace Entity
{

    public class SertifikaliTohum : IEntity
    {
       
        public int Id { get; set; }
        public int BasvuruYili { get; set; }

        public int CksDosyaNo { get; set; }
        public int SertifikaliTohumDosyaNo { get; set; }
        public string SertifikaNo { get; set; }

        public string TcNumarasi { get; set; }
        public string AdiSoyadi { get; set; }
        public string BabaAdi { get; set; }
        public string Koy { get; set; }
        public DateTime MuracaatTarih { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string FirmaAdi { get; set; }
        public string Urun { get; set; }
        public string UrunCesidi { get; set; }
        public decimal Miktari { get; set; }
        public decimal BirimFiyati { get; set; }
        public decimal ToplamMaliyet { get; set; }


    }
}
