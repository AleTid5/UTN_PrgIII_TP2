using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Deposito
    {
        public int ID { set; get; }
        public string Alias { set; get; }
        public Sucursal Sucursal { set; get; }
    }
}
