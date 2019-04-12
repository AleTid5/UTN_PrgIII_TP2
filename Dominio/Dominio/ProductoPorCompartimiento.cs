using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ProductoPorCompartimiento
    {
        public int ID { set; get; }
        public Producto Producto { set; get; }
        public int Stock { set; get; }
    }
}
