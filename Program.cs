using FactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            Fideos fideos;
            Restaurante restaurante;


            Console.WriteLine("¿En que restaurante desea pedir? argentino/usa");
            string tiporesto = Console.ReadLine();

            Console.WriteLine("¿Que fideos con salsa le gustaria pedir? tuco/carbonara");
            string tipofideo = Console.ReadLine();

            if(tiporesto == "argentino")
            {
                restaurante = new RestauranteArgentino();

                fideos = restaurante.CrearFideos(tipofideo);
                fideos.Render();
            }
            else if(tiporesto == "usa")
            {
                restaurante = new RestauranteUSA();

                fideos = restaurante.CrearFideos(tipofideo);
                fideos.Render();
            }
            else
            {
                Console.WriteLine("No ha ingresado un restaurante existente");
            }
            Console.ReadKey();
        }
    }
}
