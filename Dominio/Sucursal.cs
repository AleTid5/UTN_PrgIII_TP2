using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sucursal
    {
        public int ID { set; get; }
        public Empresa Empresa { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }

        public Empresa Empresa1
        {
            get => default(Empresa);
            set
            {
            }
        }

        // TODO: completar con los datos necesarios.
    }
}
