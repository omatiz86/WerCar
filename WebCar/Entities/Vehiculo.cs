using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Vehiculo
    {

        public string MATRICULA { get; set; }

        public string MARCA { get; set; }

        public int  MODELO { get; set; }

        public string ESTADO { get; set; }
        
    }
    public class Vehiculos : System.Collections.Generic.List<Vehiculo>
    { }

}
