using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
  public  class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Eklenilen müşteri:"+musteri.TCKN+"----"+musteri.Ad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("silinen müşteri:"+musteri.TCKN + "----" + musteri.Ad);

        }

        public void Musteriler(Musteri musteri)
        {
            Console.WriteLine("müsterinin adı:"+musteri.Ad);
            Console.WriteLine("müsterinin soyadı:"+musteri.Soyad);
            Console.WriteLine("müsteri tcknosu:"+musteri.TCKN);
            Console.WriteLine("adres:"+musteri.Adres);
            Console.WriteLine("telefon:"+musteri.Telefon);
            Console.WriteLine("e-posta:"+musteri.Eposta);
        }
    }
}
