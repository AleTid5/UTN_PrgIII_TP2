using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Compartimiento
    {
        public int ID { set; get; }
        public string Alias { set; get; }
        public Lado Lado { set; get; }
        public Cliente Cliente { set; get; }
        public ProductoPorCompartimiento ProductoPorCompartimiento { set; get; }
    }
}
