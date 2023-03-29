using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoEnCSHARP.Utlitarios
{
    public static class IntercambioUtil
    {
        public static void Intercambiar<T>(ref T item1,ref T item2)
        {
            T aux;
            aux = item1;
            item1 = item2;
            item2 = aux;
        }
    }
}
