using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class RestauranteArgentino : Restaurante
    {
        public override Fideos CrearFideos(string tipo)
        {
            if (tipo == "tuco")
            {
                return new FideosBoloñesa("Argentina");
            }
            else if (tipo == "carbonara")
            {
                return new FideosCarbonara("Argentina");
            }
            else
            {
                return null;
            }
        }
    }
}
