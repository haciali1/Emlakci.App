using System;
using System.Net.NetworkInformation;
using System.Security.Principal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var evim = new Ev();


            Console.WriteLine("Oda sayısını giriniz : ");
            evim.SetOdaSayisi(int.Parse(Console.ReadLine()));
            Console.WriteLine("Kat no giriniz : ");
            evim.Katno = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan giriniz : ");
            evim.Alan = int.Parse(Console.ReadLine());
            Console.WriteLine("Semt giriniz : ");
            evim.Semt = Console.ReadLine();
            Console.WriteLine("===================");
            Console.WriteLine("Ev bilgileri");
            Console.WriteLine(evim.EvBilgileri());
        }


     
    }

    class Ev
    {
        private int odasayisi;
        private int katno;
        private string semt;
        private string buyukluk;

        private double alan;

        public double Alan
        {
            get
            { return alan; }

            set
            {
                alan = value;

                if (alan <= 70)
                {
                    buyukluk = "Küçük Ev";
                }
                else if (alan > 70 && alan < 120)
                {
                    buyukluk = "Orta Ev";
                }
                else
                {
                    buyukluk = "Büyük ev";
                }



            }
        }


        public int Katno { get => katno; set => katno = value; }
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public string Buyukluk { get => buyukluk; }

        public void SetOdaSayisi(int odasayi) => odasayisi = Math.Abs(odasayi);

        public int GetOdaSayisi() => odasayisi;

        public string EvBilgileri() => $"Alan:{alan}\nKat No: {katno}\nOda Sayısı: {odasayisi}\nSemt: {Semt}\nBüyüklük :{buyukluk}";

    }
}