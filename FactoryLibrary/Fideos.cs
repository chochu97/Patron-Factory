using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public abstract class Fideos
    {
        protected string _descripcion;

        protected string _origen;

        public void Render()
        {
            Console.WriteLine(string.Format("Aqui tiene sus {0} hechos en {1}", _descripcion, _origen));
        }
    }
}
