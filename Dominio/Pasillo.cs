using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasillo
    {
        public int ID { set; get; }
        public string Alias { set; get; }
        public Deposito Deposito { set; get; }
        public Cliente Cliente { set; get; }
    }
}
