using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_10
{
    enum TipoDeOperacion
    {
        Venta,
        Alquiler
    }

    enum TipoDePropiedad
    {
        Departamento,
        Casa,
        Duplex,
        Penthouse,
        Terreno
    }

    class Program
    {
        static void Main(string[] args)
        {
            Propiedad prop1 = new Propiedad();
            prop1.TipoDePropiedad = "casa";
        }
    }

}
