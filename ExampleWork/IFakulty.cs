using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWork
{
    public interface IFakulty
    {
        public int Id { get; set; }
        public string FakultyName { get; set; }

        void show();

    }
}
