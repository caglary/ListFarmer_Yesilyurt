using Core.Entity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Entity
{

    public class CKS : IEntity
    {


        public int Id { get; set; }

        public int DosyaNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string AdSoyad { get; set; }

        public string BabaAdi { get; set; }
        public string KoyMahalle { get; set; }
        public string CepTelefon { get; set; }
        public string EvTelefon { get; set; }
        public DateTime KayitTarih { get; set; }


    }
}
