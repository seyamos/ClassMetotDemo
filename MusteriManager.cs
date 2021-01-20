using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine();
            Console.WriteLine(musteri.Name + ", isimli müşteri sisteme eklenmiştir");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine();
            Console.WriteLine(musteri.Name + ", isimli müşteri sistemden silinmiştir");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşterileri Listele!");
            foreach (var musteri in musteriler)
            {
                
                Console.WriteLine();
                Console.WriteLine("Adı Soyadı: " + musteri.Name + 
                    "\nNumarası: " + musteri.No + 
                    "\nYaşı: " + musteri.Age +
                    "\nAdresi: " + musteri.Address +
                    "\nKredi Notu: " + musteri.CreditRating);


            }
            
        }


    }
}
