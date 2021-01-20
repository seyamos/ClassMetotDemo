using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.No = 123456;
            musteri1.Name = "Ahmet Aksoy";
            musteri1.Age = 35;
            musteri1.Address = "İstanbul";
            musteri1.CreditRating = 80;

            Musteri musteri2 = new Musteri(); 
            musteri2.No = 789789;
            musteri2.Name = "Ali Tok";
            musteri2.Age = 40;
            musteri2.Address = "Ankara";
            musteri2.CreditRating = 70;

            Musteri musteri3 = new Musteri();
            musteri3.No = 654321;
            musteri3.Name = "Ayşe Üst";
            musteri3.Age = 45;
            musteri3.Address = "İzmir";
            musteri3.CreditRating = 90;

            
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteriler);


            musteriManager.Ekle(musteri1); //ekleme düğmesinin olması istenen yere konur.
            musteriManager.Ekle(musteri2);
            
            musteriManager.Sil(musteri3);

            







        }
    }
}
