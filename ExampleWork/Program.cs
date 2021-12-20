using Employees;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleWork
{
    class Program
    {
        static void Main(string[] args)
        {

           
            List<Bölümler> bolumler = new List<Bölümler>
            {
                new Bölümler{Id=1,FakülteId=2,FakulteAdi=Messages.FAdi,bölümAdi=Messages.BAdi},
                new Bölümler{Id=1,FakülteId=3,FakulteAdi=Messages.FAdi,bölümAdi=Messages.BAdi1},
                new Bölümler{Id=1,FakülteId=4,FakulteAdi=Messages.FAdi1,bölümAdi=Messages.BAdi2},


            };

            var results = bolumler.Where(b => b.bölümAdi==Messages.BAdi1);
            foreach (var result in results)
            {
                Console.WriteLine(result.FakulteAdi);
            }

            //var results4 = bolumler.Where(b => b.bölümAdi == Message.dekan); // dekan sınıfı public olduğundan kullanabildik.
            //foreach (var result4 in results4)
            //{
            //    Console.WriteLine(result4.Id);
            //}



            Console.WriteLine(Messages.arti);



            var results1 = bolumler.FindAll(b => b.Id==1);
            foreach (var result1 in results1)
            {
                Console.WriteLine(result1.FakulteAdi);
            }


            Console.WriteLine(Messages.arti);

            List<Ogrenci> ogrencis = new List<Ogrenci>
            {
                new Ogrenci{ Id=1,Ad=Messages.Ad1,Soyad=Messages.SAd2,No=11111,},
                new Ogrenci{ Id=1,Ad=Messages.Ad2,Soyad=Messages.SAd1,No=12221},
                new Ogrenci{ Id=1,Ad=Messages.Ad3,Soyad=Messages.SAd1,No=222},
                new Ogrenci{ Id=1,Ad=Messages.Ad4,Soyad=Messages.SAd1,No=333},
                new Ogrenci{ Id=1,Ad=Messages.Ad5,Soyad=Messages.SAd1,No=44},

            };

            var results2 = ogrencis.Where(o => o.Soyad ==Messages.SAd1);
            foreach (var result2 in results2)
            {
                Console.WriteLine(result2.Ad);
            }


            //List<Ogretmen> ogretmens = new List<Ogretmen>
            //{
            //    new Ogretmen{Id=2,Ad=Messages.Ad6,Soyad=Messages.SAd4},
            //    new Ogretmen{Id=2,Ad=Messages.Ad2,Soyad=Messages.SAd1},
            //    new Ogretmen{Id=2,Ad=Messages.Ad7,Soyad=Messages.SAd3},
            //};

            //var results5 = ogretmens.Where(og => og.Id == 1);
            //foreach (var result5 in results5)
            //{
            //    Console.WriteLine(result5.Ad);
            //}

            Console.WriteLine(Messages.arti);

            Ogrenci ogrenci = new Ogrenci();  // fonksiyon kullanımı
            ogrenci.Work();

            Console.WriteLine(Messages.arti);

            Dekan dekan = new Dekan(); // employess class içindeki public erişim bildirgeci sayesinde kullanabldik.
            dekan.Works();



        }

    }
    public static class Messages
    {
        public static string ogr = "Öğrenci Çalışır";
        public static string bolum ="Üniversite bölümleri";
    
        public static string FAdi = "Mühendislik fakültesi";
        public static string FAdi1 = "Sağlık bilimler fakültesi";
        public static string BAdi = "Bilgisayar Mühendisliği";
        public static string BAdi1 = "İnşaat Mühendisliği";
        public static string BAdi2 = "Hemşire";

        public static string Ad1 = "Seher";
        public static string Ad2 = "Mehmet";
        public static string Ad3 = "Hasan";
        public static string Ad4 = "Makbule";
        public static string Ad5 = "Ruşen";
        public static string Ad6 = "İlhan";
        public static string Ad7 = "Şener";
        public static string SAd1 = "Aslan";
        public static string SAd2 = "Çetinkaya";
        public static string SAd3 = "Kaplan";
        public static string SAd4 = "aydın";

        public static string arti = "+++++++++++++++++++++++++++++++";


    }


}
