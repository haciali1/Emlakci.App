using System;

namespace PersonelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Personel();
            Console.WriteLine("Ad Giriniz : ");
            p.Ad=Console.ReadLine();
            Console.WriteLine("Soyad Giriniz : ");
            p.Soyad=Console.ReadLine();
            Console.WriteLine("İşe giriş yılını giriniz : ");
            p.GirisYil=int.Parse(Console.ReadLine());
            Console.WriteLine("Personel Bilgileri :");
            Console.WriteLine(p.PersonelBiilgi());
        }
    }
    class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private double maas;
        public double Maas { get => maas;  }
      
        private int girisyil;

        public int GirisYil
        {
            get { return girisyil; }

            set 
            {
                girisyil = value;

               maas = 10000 + ((DateTime.Now.Year - girisyil)*1000);

            }
        }
        public string PersonelBiilgi()=> $"Personel Adı :{Ad}\nPersonel Soyadı :{Soyad}\nPersonel Maaşı : {Maas}";
      


    }




}
// Personelin maaşı işe giriş yılına göre hesaplanacak
//Maas=10000+(calistigiyil*1000);