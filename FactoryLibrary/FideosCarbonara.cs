using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class FideosCarbonara : Fideos
    {
        public FideosCarbonara(string origen)
        {
            _descripcion = "Fideos con Salsa Carbonara";
            _origen = origen;   
        }
    }
}
