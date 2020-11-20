using Core.Entity;
using System;
namespace Entity
{

    public class Mgd : IEntity
    {
    
        public int Id { get; set; }
        public int SiraNo { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string MahalleKoy { get; set; }
        public string IsletmeAdi { get; set; }
        public string BabaAdi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TcKimlikNo { get; set; }
        public decimal MazotAlani { get; set; }
        public decimal MazotDesteklemeMiktari { get; set; }
        public decimal GubreAlani { get; set; }
        public decimal GubreDesteklemeMiktari { get; set; }
        public decimal ToplamDesteklemeMiktari { get; set; }
    }
}
