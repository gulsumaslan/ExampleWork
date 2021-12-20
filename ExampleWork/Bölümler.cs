using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWork
{
    public class Bölümler:IFakulte
    {
        public int Id { get; set; }
        public int FakülteId { get; set; }
        public string bölümAdi { get; set; }


        public string FakulteAdi { get ; set ; }

        public void show()
        {
            Console.WriteLine(Messages.bolum);
        }
    }
}
