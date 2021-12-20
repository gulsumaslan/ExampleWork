using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWork
{
    public interface IFakulte
    {
        public int Id { get; set; }
        public string FakulteAdi { get; set; }

        void show();

    }
}
