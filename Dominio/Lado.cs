using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lado
    {
        public int ID { set; get; }
        public string Alias { set; get; }
        public Pasillo Pasillo { set; get; }
        public Cliente Cliente { set; get; }
    }
}
