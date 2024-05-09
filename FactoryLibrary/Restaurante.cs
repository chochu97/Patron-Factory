using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public abstract class Restaurante
    {

        public abstract Fideos CrearFideos(string tipo);

    }
}
