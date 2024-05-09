using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class FideosBoloñesa : Fideos
    {

        public FideosBoloñesa(string origen)
        {
            _descripcion = "Fideos con Salasa Boloñesa";
            _origen = origen;
        }

    }
}
