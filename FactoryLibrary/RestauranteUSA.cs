using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class RestauranteUSA : Restaurante
    {
        public override Fideos CrearFideos(string tipo)
        {
            if(tipo == "tuco")
            {
                return new FideosBoloñesa("USA");
            }
            else if(tipo == "carbonara")
            {
                return new FideosCarbonara("USA");
            }
            else
            {
                return null;
            }

        }
    }
}
