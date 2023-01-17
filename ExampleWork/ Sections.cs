using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWork
{
    public class  Sections:IFakulty
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string sectionName { get; set; }


        public string FakultyName { get ; set ; }

        public void show()
        {
            Console.WriteLine(Messages.section);
        }
    }
}
