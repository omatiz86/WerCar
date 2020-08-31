using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {

        public string DOC_CLIENTE { get; set; }

        public string NOMBRE { get; set; }

        public string DIRECCION { get; set; }

        public string TELEFONO { get; set; }


    }

    public class Clientes : System.Collections.Generic.List<Cliente>
    { }

}
