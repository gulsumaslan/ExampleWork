using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

     interface IEmployees// burayı public yaparsak tanımladığım classların hepsine başka projelerde erişebiliriz çünkü implement ediliyor.
    {
        public string Id { get; set; }
        void Works();

    }


    public class Dekan : IEmployees  // sadece dekan sınıfına erişebilirz başka projede
    {
        public string Id { get; set; }


        public void Works()
        {
            Console.WriteLine(Message.dekan);
        }
    }

    class DekanYardimcisi : IEmployees
    {
        public string Id { get; set; }



        public void Works()
        {
            Console.WriteLine(Message.dekanyardımcısı);
        }
    }

    class Personel : IEmployees
    {
        public string Id { get; set; }



        public void Works()
        {
            Console.WriteLine(Message.personel);
        }
    }



    public static class Message { // public tanımlandığından examplework projesinde kullanılabilir.
        public static string dekan = "üniversite de dekan";
        public static string dekanyardımcısı = "üniversite de dekan yardımcısı";
        public static string personel = "üniversite de güvenlik personeli";
    } }
