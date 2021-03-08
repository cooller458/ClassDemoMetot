using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class musteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarı ile eklendi! : " + musteri.Adi  );

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri listelendi."+ musteri1);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri kaydı silindi."+ musteri.Adi);
        }
    }
}
