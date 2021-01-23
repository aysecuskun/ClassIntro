using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m = new Musteri();
            m.Ad = "ayşe";
            m.Soyad = "Cuşkun";
            m.TCKN = 1233456789;
            m.Adres = "istanbul";
            m.Eposta ="ayse@gmail.com";


            Musteri m1 = new Musteri();
            m1.Ad = "zehra";
            m1.Soyad = "Cuşkun";
            m1.TCKN = 1236789787;
            m1.Adres = "istanbul";
            m1.Eposta = "zehra@gmail.com";

            Musteri[] musteri = new Musteri[] { m, m1 };

            foreach (var item in musteri)//istersen verilen verileri burda listelersein istersen de metot yardımı ile listeleyebiliriz.
            {
                Console.WriteLine(item.Ad);//basmak istediğimiz tüm özellikler burda 
            }

            MusteriManager manager = new MusteriManager();
            manager.Musteriler(m);
            manager.MusteriEkle(m1);
            manager.MusteriSil(m);

            Console.ReadLine();
        }
        
    }
}
