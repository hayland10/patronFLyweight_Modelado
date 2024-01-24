using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronFLyweight
{
    interface FlyWeight
    {
        void ColcaNombre(string nombre);
        void CalcularCosto();
        void Mostrar();
        string ObtenerNombre();
    }
}
