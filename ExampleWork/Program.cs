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

           
            List<Sections> sections = new List<Sections>
            {
                new Sections{Id=1,FakültyId=2,FakultyName=Messages.FName,sectionName=Messages.BName},
                new Sections{Id=1,FakültyId=3,FakultyName=Messages.FName,sectionName=Messages.BName1},
                new Sections{Id=1,FakültyId=4,FakultyName=Messages.FName1,sectionName=Messages.BName2},


            };

            var results = sections.Where(b => b.sectionName==Messages.BName1);
            foreach (var result in results)
            {
                Console.WriteLine(result.FakultyName);
            }

            //var results4 = sections.Where(b => b.sectionName == Message.dean); // dekan sınıfı public olduğundan kullanabildik.
            //foreach (var result4 in results4)
            //{
            //    Console.WriteLine(result4.Id);
            //}



            Console.WriteLine(Messages.arti);



            var results1 = sections.FindAll(b => b.Id==1);
            foreach (var result1 in results1)
            {
                Console.WriteLine(result1.FakultyName);
            }


            Console.WriteLine(Messages.arti);

            List<Student> students = new List<Student>
            {
                new Student{ Id=1,Name=Messages.Name1,SurName=Messages.SName2,No=11111,},
                new Student{ Id=1,Name=Messages.Name2,SurName=Messages.SName1,No=12221},
                new Student{ Id=1,Name=MessagesName3,SurName=Messages.SName1,No=222},
                new Student{ Id=1,Name=Messages.Name4,SurName=Messages.SName1,No=333},
                new Student{ Id=1Name=Messages.Name5,SurName=Messages.SName1,No=44},

            };

            var results2 = students.Where(o => o.SurName ==Messages.Name1);
            foreach (var result2 in results2)
            {
                Console.WriteLine(result2.Name);
            }


            //List<Teacher> teachers = new List<Teacher>
            //{
            //    new Teacher{Id=2,Name=Messages.Name6,SurName=Messages.SName4},
            //    new Teacher{Id=2Name=Messages.Name2,SurName=Messages.SName1},
            //    newTeacher{Id=2,Name=Messages.Name7,SurName=Messages.SName3},
            //};

            //var results5 = teachers.Where(og => og.Id == 1);
            //foreach (var result5 in results5)
            //{
            //    Console.WriteLine(result5.Name);
            //}

            Console.WriteLine(Messages.arti);

            Student student  = new Student ();  // fonksiyon kullanımı
            student .Work();

            Console.WriteLine(Messages.arti);

            Dean dean = new Dean(); // employess class içindeki public erişim bildirgeci sayesinde kullanabldik.
            dean.Works();



        }

    }
    public static class Messages
    {
        public static string ogr = "Öğrenci Çalışır";
        public static string section ="Üniversite bölümleri";
    
        public static string FName = "Mühendislik fakültesi";
        public static string FName1 = "Sağlık bilimler fakültesi";
        public static string BName = "Bilgisayar Mühendisliği";
        public static string BName1 = "İnşaat Mühendisliği";
        public static string BName2 = "Hemşire";

        public static string Name1 = "Seher";
        public static string Name2 = "Mehmet";
        public static string Name3 = "Hasan";
        public static string Name4 = "Makbule";
        public static string Name5 = "Ruşen";
        public static string Name6 = "İlhan";
        public static string Name7 = "Şener";
        public static string SName1 = "Aslan";
        public static string SName2 = "Çetinkaya";
        public static string SName3 = "Kaplan";
        public static string SName4 = "aydın";

        public static string arti = "+++++++++++++++++++++++++++++++";


    }


}
