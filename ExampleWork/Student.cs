using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWork
{
    class Student:Teachers
    {

        public int No { get; set; }

        public void Work()
        {
            Console.WriteLine(Messages.ogr);
        }
    }

 


}
