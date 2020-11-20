using Core.Entity;
using System;

namespace Entity
{

    public class Ciftci : IEntity
    {

        public int Id { get; set; }
        public string TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string OlumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniDurum { get; set; }
        public string CepTelefon { get; set; }
        public string EvTelefon { get; set; }
        public string Email { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string KoyMahalle { get; set; }

       
    }
}
