using Core.Entity;
using System;
namespace Entity
{

    public class Parseller:IEntity
    {
        public int Id { get; set; }
        public string IsletmeAdi { get; set; }
        public string TcNo { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Koy { get; set; }
        public string Ada { get; set; }
        public string Parsel { get; set; }
        public decimal KullanilanAlan { get; set; }
        public decimal ParselAlani { get; set; }
        public string TarimsalNo { get; set; }
        public string Urun { get; set; }
        public string TarimSekli { get; set; }
        public decimal EkiliAlan { get; set; }
        public DateTime EkimTarihi { get; set; }
        public DateTime HasatTarihi { get; set; }
    }
}
