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


    public class Dean : IEmployees  // sadece dekan sınıfına erişebilirz başka projede
    {
        public string Id { get; set; }


        public void Works()
        {
            Console.WriteLine(Message.dean);
        }
    }

    class Vicedean : IEmployees
    {
        public string Id { get; set; }



        public void Works()
        {
            Console.WriteLine(Message.vicedean);
        }
    }

    class Employee: IEmployees
    {
        public string Id { get; set; }



        public void Works()
        {
            Console.WriteLine(Message.employee);
        }
    }



    public static class Message { // public tanımlandığından examplework projesinde kullanılabilir.
        public static string dean = "dean at university";
        public static string vicedean = "vice dean at university";
        public static string employee = "security staff at university";
    } }
