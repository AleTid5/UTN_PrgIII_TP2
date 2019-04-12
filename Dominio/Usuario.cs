using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        /*
         * 1. Admin
         * 2. Vendedor
         * 3. Cliente
         */
        public int Rol { set; get; }
        public Sucursal Sucursal { set; get; }

        // TODO: Completar los campos faltantes.
    }
}
